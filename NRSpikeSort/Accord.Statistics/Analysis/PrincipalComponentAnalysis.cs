// Accord Statistics Library
// The Accord.NET Framework
// http://accord-net.origo.ethz.ch
//
// Copyright © César Souza, 2009-2011
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Statistics.Analysis
{

    using System;
    using System.Collections.ObjectModel;
    using Accord.Math;
    using Accord.Math.Decompositions;


    /// <summary>
    ///   Principal component analysis (PCA) is a technique used to reduce
    ///   multidimensional data sets to lower dimensions for analysis.
    /// </summary>
    /// 
    /// <remarks>
    /// <para>
    ///   Principal Components Analysis or the Karhunen-Loeve expansion is a
    ///   classical method for dimensionality reduction or exploratory data
    ///   analysis.</para>
    /// <para>
    ///   Mathematically, PCA is a process that decomposes the covariance matrix of a matrix
    ///   into two parts: eigenvalues and column eigenvectors, whereas Singular Value Decomposition
    ///   (SVD) decomposes a matrix per se into three parts: singular values, column eigenvectors,
    ///   and row eigenvectors. The relationships between PCA and SVD lie in that the eigenvalues 
    ///   are the square of the singular values and the column vectors are the same for both.</para>
    ///   
    /// <para>
    ///   This class uses SVD on the data set which generally gives better numerical accuracy.</para>
    ///</remarks>
    ///
    ///<example>
    ///  <code>
    ///  // Below is the same data used on the excellent paper "Tutorial
    ///  //   On Principal Component Analysis", by Lindsay Smith (2002).
    ///  double[,] sourceMatrix = 
    ///  {
    ///      { 2.5,  2.4 },
    ///      { 0.5,  0.7 },
    ///      { 2.2,  2.9 },
    ///      { 1.9,  2.2 },
    ///      { 3.1,  3.0 },
    ///      { 2.3,  2.7 },
    ///      { 2.0,  1.6 },
    ///      { 1.0,  1.1 },
    ///      { 1.5,  1.6 },
    ///      { 1.1,  0.9 }
    ///  }; 
    /// 
    ///  // Creates the Principal Component Analysis of the given source
    ///  var pca = new PrincipalComponentAnalysis(sourceMatrix, AnalysisMethod.Correlation);
    ///    
    ///  // Compute the Principal Component Analysis
    ///  pca.Compute();
    ///    
    ///  // Creates a projection considering 80% of the information
    ///  double[,] components = pca.Transform(sourceMatrix, 0.8f, true);
    ///  </code>
    ///</example>
    ///
    [Serializable]
    public class PrincipalComponentAnalysis : IMultivariateAnalysis, IProjectionAnalysis
    {

        private double[,] source;
        private double[,] result;

        private double[] columnMeans;
        private double[] columnStdDev;

        private double[,] eigenvectors;
        private double[] eigenvalues;
        private double[] singularValues;

        private PrincipalComponentCollection componentCollection;
        private double[] componentProportions;
        private double[] componentCumulative;

        private AnalysisMethod analysisMethod;
        private bool overwriteSourceMatrix;

        //---------------------------------------------


        #region Constructor
        /// <summary>
        ///   Constructs a new Principal Component Analysis.
        /// </summary>
        /// 
        /// <param name="data">The source data to perform analysis. The matrix should contain
        /// variables as columns and observations of each variable as rows.</param>
        /// <param name="method">The analysis method to perform. Default is <see cref="AnalysisMethod.Center"/>.</param>
        /// 
        public PrincipalComponentAnalysis(double[,] data, AnalysisMethod method)
        {
            if (data == null) throw new ArgumentNullException("data");

            this.Source = data;
            this.analysisMethod = method;
        }

        /// <summary>
        ///   Constructs a new Principal Component Analysis.
        /// </summary>
        /// 
        /// <param name="data">The source data to perform analysis. The matrix should contain
        /// variables as columns and observations of each variable as rows.</param>
        /// 
        public PrincipalComponentAnalysis(double[,] data)
            : this(data, AnalysisMethod.Center)
        {
        }
        #endregion


        //---------------------------------------------


        #region Properties
        /// <summary>
        ///   Returns the original data supplied to the analysis.
        /// </summary>
        /// 
        /// <value>The original data matrix supplied to the analysis.</value>
        /// 
        public double[,] Source
        {
            get { return this.source; }
            private set
            {
                if (value != source)
                {
                    source = value;

                    // Calculate common measures to speedup other calculations
                    this.columnMeans = Accord.Statistics.Tools.Mean(source);
                    this.columnStdDev = Accord.Statistics.Tools.StandardDeviation(source, columnMeans);
                }
            }
        }

        /// <summary>
        ///   Gets the resulting projection of the source
        ///   data given on the creation of the analysis 
        ///   into the space spawned by principal components.
        /// </summary>
        /// 
        /// <value>The resulting projection in principal component space.</value>
        /// 
        public double[,] Result
        {
            get { return this.result; }
            protected set { this.result = value; }
        }

        /// <summary>
        ///   Gets a matrix whose columns contain the principal components. Also known as the Eigenvectors or loadings matrix.
        /// </summary>
        /// 
        /// <value>The matrix of principal components.</value>
        /// 
        public double[,] ComponentMatrix
        {
            get { return this.eigenvectors; }
            protected set { this.eigenvectors = value; }
        }

        /// <summary>
        ///   Gets the Principal Components in a object-oriented structure.
        /// </summary>
        /// 
        /// <value>The collection of principal components.</value>
        /// 
        public PrincipalComponentCollection Components
        {
            get { return componentCollection; }
        }

        /// <summary>
        ///   The respective role each component plays in the data set.
        /// </summary>
        /// 
        /// <value>The component proportions.</value>
        /// 
        public double[] ComponentProportions
        {
            get { return componentProportions; }
        }

        /// <summary>
        ///   The cumulative distribution of the components proportion role. Also known
        ///   as the cumulative energy of the principal components.
        /// </summary>
        /// 
        /// <value>The cumulative proportions.</value>
        /// 
        public double[] CumulativeProportions
        {
            get { return componentCumulative; }
        }

        /// <summary>
        ///   Provides access to the Singular Values stored during the analysis.
        ///   If a covariance method is chosen, then it will contain an empty vector.
        /// </summary>
        /// 
        /// <value>The singular values.</value>
        /// 
        public double[] SingularValues
        {
            get { return singularValues; }
            protected set { singularValues = value; }
        }

        /// <summary>
        ///   Provides access to the Eigenvalues stored during the analysis.
        /// </summary>
        /// 
        /// <value>The eigenvalues.</value>
        /// 
        public double[] Eigenvalues
        {
            get { return eigenvalues; }
            protected set { eigenvalues = value; }
        }

        /// <summary>
        ///   Gets the column standard deviations of the source data given at method construction.
        /// </summary>
        /// 
        public double[] StandardDeviations
        {
            get { return this.columnStdDev; }
        }

        /// <summary>
        ///   Gets the column mean of the source data given at method construction.
        /// </summary>
        /// 
        public double[] Means
        {
            get { return this.columnMeans; }
        }

        /// <summary>
        ///   Gets or sets the method used by this analysis.
        /// </summary>
        /// 
        public AnalysisMethod Method
        {
            get { return this.analysisMethod; }
            set { this.analysisMethod = value; }
        }

        /// <summary>
        ///   Gets or sets whether calculations will be performed overwriting
        ///   data in the original source matrix, using less memory.
        /// </summary>
        /// 
        public bool Overwrite
        {
            get { return overwriteSourceMatrix; }
            set { overwriteSourceMatrix = value; }
        }
        #endregion


        //---------------------------------------------


        #region Public Methods

        /// <summary>
        ///   Computes the Principal Component Analysis algorithm.
        /// </summary>
        /// 
        public virtual void Compute()
        {

            // Center and standardize the source matrix
            double[,] matrix = Adjust(source, overwriteSourceMatrix);


            // Perform the Singular Value Decomposition (SVD) of the matrix
            SingularValueDecomposition svd = new SingularValueDecomposition(matrix, true, true, true, true);
            singularValues = svd.Diagonal;

            //  The principal components of 'Source' are the eigenvectors of Cov(Source). Thus if we
            //  calculate the SVD of 'matrix' (which is Source standardized), the columns of matrix V
            //  (right side of SVD) will be the principal components of Source.                        

            // The right singular vectors contains the principal components of the data matrix
            eigenvectors = svd.RightSingularVectors;

            // The left singular vectors contains the factor scores for the principal components
            result = svd.LeftSingularVectors.MultiplyByDiagonal(singularValues);


            // Eigenvalues are the square of the singular values
            eigenvalues = new double[singularValues.Length];
            for (int i = 0; i < singularValues.Length; i++)
                eigenvalues[i] = singularValues[i] * singularValues[i];

            // Computes additional information about the analysis and creates the
            //  object-oriented structure to hold the principal components found.
            CreateComponents();
        }

        /// <summary>
        ///   Projects a given matrix into principal component space.
        /// </summary>
        /// 
        /// <param name="data">The matrix to be projected.</param>
        /// 
        public double[,] Transform(double[,] data)
        {
            return this.Transform(data, componentCollection.Count);
        }

        /// <summary>
        ///   Projects a given matrix into principal component space.
        /// </summary>
        /// 
        /// <param name="data">The matrix to be projected.</param>
        /// <param name="dimensions">The number of components to consider.</param>
        /// 
        public virtual double[,] Transform(double[,] data, int dimensions)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            if (eigenvectors == null)
                throw new InvalidOperationException("The analysis must have been computed first.");

            //if (data.GetLength(1) != source.GetLength(1))
            //    throw new DimensionMismatchException("data",
            //        "The input data should have the same number of columns as the original data.");

            if (dimensions < 0 || dimensions > Components.Count)
            {
                throw new ArgumentOutOfRangeException("dimensions",
                    "The specified number of dimensions must be equal or less than the " +
                    "number of components available in the Components collection property.");
            }

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            // Center the data
            data = Adjust(data, false);

            // multiply the data matrix by the selected eigenvectors
            // TODO: Use cache-friendly multiplication
            double[,] r = new double[rows, dimensions];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < dimensions; j++)
                    for (int k = 0; k < cols; k++)
                        r[i, j] += data[i, k] * eigenvectors[k, j];

            return r;
        }

        /// <summary>
        ///   Reverts a set of projected data into it's original form. Complete reverse
        ///   transformation is only possible if all components are present, and, if the
        ///   data has been standardized, the original standard deviation and means of
        ///   the original matrix are known.
        /// </summary>
        /// 
        /// <param name="data">The pca transformed data.</param>
        /// 
        public virtual double[,] Revert(double[,] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            int components = componentCollection.Count;
            double[,] reversion = new double[rows, components];


            // Revert the data (reversion = data * eigenVectors.Transpose())
            for (int i = 0; i < components; i++)
                for (int j = 0; j < rows; j++)
                    for (int k = 0; k < cols; k++)
                        reversion[j, i] += data[j, k] * eigenvectors[i, k];


            // if the data has been standardized or centered,
            //  we need to revert those operations as well
            if (this.analysisMethod == AnalysisMethod.Standardize)
            {
                // multiply by standard deviation and add the mean
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < components; j++)
                        reversion[i, j] = (reversion[i, j] * columnStdDev[j]) + columnMeans[j];
            }
            else
            {
                // only add the mean
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < components; j++)
                        reversion[i, j] = reversion[i, j] + columnMeans[j];
            }

            return reversion;
        }


        /// <summary>
        ///   Returns the minimal number of principal components
        ///   required to represent a given percentile of the data.
        /// </summary>
        /// 
        /// <param name="threshold">The percentile of the data requiring representation.</param>
        /// <returns>The minimal number of components required.</returns>
        /// 
        public int GetNumberOfComponents(float threshold)
        {
            if (threshold < 0 || threshold > 1.0)
                throw new ArgumentException("Threshold should be a value between 0 and 1", "threshold");

            for (int i = 0; i < componentCumulative.Length; i++)
            {
                if (componentCumulative[i] >= threshold)
                    return i + 1;
            }

            return componentCumulative.Length;
        }

        #endregion


        //---------------------------------------------


        #region Protected Methods
        /// <summary>
        ///   Adjusts a data matrix, centering and standardizing its values
        ///   using the already computed column's means and standard deviations.
        /// </summary>
        /// 
        protected internal double[,] Adjust(double[,] matrix, bool inPlace)
        {
            // Center the data around the mean. Will have no effect if
            //  the data is already centered (the mean will be zero).
            double[,] result = matrix.Center(columnMeans, inPlace);

            // Check if we also have to standardize our data (convert to Z Scores).
            if (this.analysisMethod == AnalysisMethod.Standardize)
            {
                for (int j = 0; j < columnStdDev.Length; j++)
                    if (columnStdDev[j] == 0) throw new ArithmeticException("Standard deviation cannot be" +
                        " zero (cannot standardize the constant variable at column index " + j + ").");

                // Yes. Divide by standard deviation
                result.Standardize(columnStdDev, true);
            }

            return result;
        }

        /// <summary>
        ///   Creates additional information about principal components.
        /// </summary>
        /// 
        protected void CreateComponents()
        {
            int numComponents = singularValues.Length;
            componentProportions = new double[numComponents];
            componentCumulative = new double[numComponents];

            // Calculate proportions
            double sum = 0.0;
            for (int i = 0; i < numComponents; i++)
                sum += System.Math.Abs(eigenvalues[i]);
            sum = (sum == 0) ? 0.0 : (1.0 / sum);

            for (int i = 0; i < numComponents; i++)
                componentProportions[i] = System.Math.Abs(eigenvalues[i]) * sum;

            // Calculate cumulative proportions
            this.componentCumulative[0] = this.componentProportions[0];
            for (int i = 1; i < this.componentCumulative.Length; i++)
                this.componentCumulative[i] = this.componentCumulative[i - 1] + this.componentProportions[i];

            // Creates the object-oriented structure to hold the principal components
            PrincipalComponent[] components = new PrincipalComponent[singularValues.Length];
            for (int i = 0; i < components.Length; i++)
                components[i] = new PrincipalComponent(this, i);
            this.componentCollection = new PrincipalComponentCollection(components);
        }
        #endregion

    }


    #region Support Classes
    /// <summary>
    /// <para>
    ///   Represents a Principal Component found in the Principal Component Analysis,
    ///   allowing it to be bound to controls like the DataGridView. </para>
    /// <para>
    ///   This class cannot be instantiated.</para>   
    /// </summary>
    /// 
    [Serializable]
    public class PrincipalComponent
    {

        private int index;
        private PrincipalComponentAnalysis principalComponentAnalysis;


        /// <summary>
        ///   Creates a principal component representation.
        /// </summary>
        /// 
        /// <param name="analysis">The analysis to which this component belongs.</param>
        /// <param name="index">The component index.</param>
        /// 
        internal PrincipalComponent(PrincipalComponentAnalysis analysis, int index)
        {
            this.index = index;
            this.principalComponentAnalysis = analysis;
        }


        /// <summary>
        ///   Gets the Index of this component on the original analysis principal component collection.
        /// </summary>
        /// 
        public int Index
        {
            get { return this.index; }
        }

        /// <summary>
        ///   Returns a reference to the parent analysis object.
        /// </summary>
        /// 
        public PrincipalComponentAnalysis Analysis
        {
            get { return this.principalComponentAnalysis; }
        }

        /// <summary>
        ///   Gets the proportion of data this component represents.
        /// </summary>
        /// 
        public double Proportion
        {
            get { return this.principalComponentAnalysis.ComponentProportions[index]; }
        }

        /// <summary>
        ///   Gets the cumulative proportion of data this component represents.
        /// </summary>
        /// 
        public double CumulativeProportion
        {
            get { return this.principalComponentAnalysis.CumulativeProportions[index]; }
        }

        /// <summary>
        ///   If available, gets the Singular Value of this component found during the Analysis.
        /// </summary>
        /// 
        public double SingularValue
        {
            get { return this.principalComponentAnalysis.SingularValues[index]; }
        }

        /// <summary>
        ///   Gets the Eigenvalue of this component found during the analysis.
        /// </summary>
        /// 
        public double Eigenvalue
        {
            get { return this.principalComponentAnalysis.Eigenvalues[index]; }
        }

        /// <summary>
        ///   Gets the Eigenvector of this component.
        /// </summary>
        /// 
        public double[] Eigenvector
        {
            get
            {
                double[] eigv = new double[principalComponentAnalysis.ComponentMatrix.GetLength(0)];

                for (int i = 0; i < eigv.Length; i++)
                    eigv[i] = principalComponentAnalysis.ComponentMatrix[i, index];
                return eigv;
            }
        }
    }

    /// <summary>
    ///   Represents a Collection of Principal Components found in the 
    ///   <see cref="PrincipalComponentAnalysis"/>. This class cannot be instantiated.
    /// </summary>
    /// 
    [Serializable]
    public class PrincipalComponentCollection : ReadOnlyCollection<PrincipalComponent>
    {
        internal PrincipalComponentCollection(PrincipalComponent[] components)
            : base(components) { }
    }
    #endregion

}

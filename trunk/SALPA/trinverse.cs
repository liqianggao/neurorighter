// NeuroRighter v0.04
// Copyright (c) 2008 John Rolston
//
// This file is part of NeuroRighter v0.04.
//
// NeuroRighter v0.04 is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NeuroRighter v0.04 is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with NeuroRighter v0.04.  If not, see <http://www.gnu.org/licenses/>. 
//
// This code is a derivation of non-functioning code developed by Sergey Bochkanov (ALGLIB project),
// His code is in turn based on LAPACK: http://www.netlib.org/lapack/.

using System;
namespace NeuroRighter
{
    class trinverse
    {
        /*************************************************************************
        Triangular matrix inversion

        The subroutine inverts the following types of matrices:
            * upper triangular
            * upper triangular with unit diagonal
            * lower triangular
            * lower triangular with unit diagonal

        In case of an upper (lower) triangular matrix,  the  inverse  matrix  will
        also be upper (lower) triangular, and after the end of the algorithm,  the
        inverse matrix replaces the source matrix. The elements  below (above) the
        main diagonal are not changed by the algorithm.

        If  the matrix  has a unit diagonal, the inverse matrix also  has  a  unit
        diagonal, and the diagonal elements are not passed to the algorithm.

        Input parameters:
            A       -   matrix.
                        Array whose indexes range within [1..N, 1..N].
            N       -   size of matrix A.
            IsUpper -   True, if the matrix is upper triangular.
            IsUnitTriangular
                    -   True, if the matrix has a unit diagonal.

        Output parameters:
            A       -   inverse matrix (if the problem is not degenerate).

        Result:
            True, if the matrix is not singular.
            False, if the matrix is singular.

          -- LAPACK routine (version 3.0) --
             Univ. of Tennessee, Univ. of California Berkeley, NAG Ltd.,
             Courant Institute, Argonne National Lab, and Rice University
             February 29, 1992
        *************************************************************************/
        public static bool invtriangular(ref double[,] a,
            int n,
            bool isupper,
            bool isunittriangular)
        {
            bool result = new bool();
            bool nounit = new bool();
            int i = 0;
            int j = 0;
            int nmj = 0;
            int jm1 = 0;
            int jp1 = 0;
            double v = 0;
            double ajj = 0;
            double[] t = new double[0];
            int i_ = 0;

            result = true;
            t = new double[n + 1];

            //
            // Test the input parameters.
            //
            nounit = !isunittriangular;
            if (isupper)
            {

                //
                // Compute inverse of upper triangular matrix.
                //
                for (j = 1; j <= n; j++)
                {
                    if (nounit)
                    {
                        if (a[j, j] == 0)
                        {
                            result = false;
                            return result;
                        }
                        a[j, j] = 1 / a[j, j];
                        ajj = -a[j, j];
                    }
                    else
                    {
                        ajj = -1;
                    }

                    //
                    // Compute elements 1:j-1 of j-th column.
                    //
                    if (j > 1)
                    {
                        jm1 = j - 1;
                        for (i_ = 1; i_ <= jm1; i_++)
                        {
                            t[i_] = a[i_, j];
                        }
                        for (i = 1; i <= j - 1; i++)
                        {
                            if (i < j - 1)
                            {
                                v = 0.0;
                                for (i_ = i + 1; i_ <= jm1; i_++)
                                {
                                    v += a[i, i_] * t[i_];
                                }
                            }
                            else
                            {
                                v = 0;
                            }
                            if (nounit)
                            {
                                a[i, j] = v + a[i, i] * t[i];
                            }
                            else
                            {
                                a[i, j] = v + t[i];
                            }
                        }
                        for (i_ = 1; i_ <= jm1; i_++)
                        {
                            a[i_, j] = ajj * a[i_, j];
                        }
                    }
                }
            }
            else
            {

                //
                // Compute inverse of lower triangular matrix.
                //
                for (j = n; j >= 1; j--)
                {
                    if (nounit)
                    {
                        if (a[j, j] == 0)
                        {
                            result = false;
                            return result;
                        }
                        a[j, j] = 1 / a[j, j];
                        ajj = -a[j, j];
                    }
                    else
                    {
                        ajj = -1;
                    }
                    if (j < n)
                    {

                        //
                        // Compute elements j+1:n of j-th column.
                        //
                        nmj = n - j;
                        jp1 = j + 1;
                        for (i_ = jp1; i_ <= n; i_++)
                        {
                            t[i_] = a[i_, j];
                        }
                        for (i = j + 1; i <= n; i++)
                        {
                            if (i > j + 1)
                            {
                                v = 0.0;
                                for (i_ = jp1; i_ <= i - 1; i_++)
                                {
                                    v += a[i, i_] * t[i_];
                                }
                            }
                            else
                            {
                                v = 0;
                            }
                            if (nounit)
                            {
                                a[i, j] = v + a[i, i] * t[i];
                            }
                            else
                            {
                                a[i, j] = v + t[i];
                            }
                        }
                        for (i_ = jp1; i_ <= n; i_++)
                        {
                            a[i_, j] = ajj * a[i_, j];
                        }
                    }
                }
            }
            return result;
        }
    }
}
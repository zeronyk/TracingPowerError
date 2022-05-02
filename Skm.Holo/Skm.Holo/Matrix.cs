using System;

namespace Skm.Holo
{
	public class Matrix
	{
		public static Matrix Zero = new Matrix
			(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		public static Matrix Unit = new Matrix
			(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
		public static Matrix NaN = new Matrix
			(float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN);

		#region Eigenschaften

		public float m00 { get; set; }
		public float m10 { get; set; }
		public float m20 { get; set; }
		public float m30 { get; set; }
		public float m01 { get; set; }
		public float m11 { get; set; }
		public float m21 { get; set; }
		public float m31 { get; set; }
		public float m02 { get; set; }
		public float m12 { get; set; }
		public float m22 { get; set; }
		public float m32 { get; set; }
		public float m03 { get; set; }
		public float m13 { get; set; }
		public float m23 { get; set; }
		public float m33 { get; set; }

		public Vector3 Position
		{
			get
			{
				return new Vector3(this.m03, this.m13, this.m23);
			}
			set
			{
				this.m03 = value.x;
				this.m13 = value.y;
				this.m23 = value.z;
			}
		}
		public Vector3 Scale
		{
			get
			{
				Vector3 tempScale = Vector3.NaN;
				Matrix tempMatrix = null;
				tempMatrix = null;
				return tempScale;
			}
		}

		#endregion

		#region Indexer

		public float this[int row, int column]
		{
			get
			{
				return this[row + column * 4];
			}
			set
			{
				this[row + column * 4] = value;
			}
		}
		public float this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return this.m00;
					case 1: return this.m10;
					case 2: return this.m20;
					case 3: return this.m30;
					case 4: return this.m01;
					case 5: return this.m11;
					case 6: return this.m21;
					case 7: return this.m31;
					case 8: return this.m02;
					case 9: return this.m12;
					case 10: return this.m22;
					case 11: return this.m32;
					case 12: return this.m03;
					case 13: return this.m13;
					case 14: return this.m23;
					case 15: return this.m33;
					default:
						throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
			set
			{
				switch (index)
				{
					case 0: this.m00 = value; break;
					case 1: this.m10 = value; break;
					case 2: this.m20 = value; break;
					case 3: this.m30 = value; break;
					case 4: this.m01 = value; break;
					case 5: this.m11 = value; break;
					case 6: this.m21 = value; break;
					case 7: this.m31 = value; break;
					case 8: this.m02 = value; break;
					case 9: this.m12 = value; break;
					case 10: this.m22 = value; break;
					case 11: this.m32 = value; break;
					case 12: this.m03 = value; break;
					case 13: this.m13 = value; break;
					case 14: this.m23 = value; break;
					case 15: this.m33 = value; break;
					default:
						throw new IndexOutOfRangeException("Invalid matrix index!");
				}
			}
		}

		#endregion

		#region Konstruktor

		public Matrix()
		{
			//Einheitsmatrix
			this.m00 = 1;
			this.m01 = 0;
			this.m02 = 0;
			this.m03 = 0;
			this.m10 = 0;
			this.m11 = 1;
			this.m12 = 0;
			this.m13 = 0;
			this.m20 = 0;
			this.m21 = 0;
			this.m22 = 1;
			this.m23 = 0;
			this.m30 = 0;
			this.m31 = 0;
			this.m32 = 0;
			this.m33 = 1;
		}

		public Matrix(float m00, float m10, float m20, float m30,
			float m01, float m11, float m21, float m31,
			float m02, float m12, float m22, float m32,
			float m03, float m13, float m23, float m33)
		{
			this.m00 = m00;
			this.m10 = m10;
			this.m20 = m20;
			this.m30 = m30;
			this.m01 = m01;
			this.m11 = m11;
			this.m21 = m21;
			this.m31 = m31;
			this.m02 = m02;
			this.m12 = m12;
			this.m22 = m22;
			this.m32 = m32;
			this.m03 = m03;
			this.m13 = m13;
			this.m23 = m23;
			this.m33 = m33;
		}

		public Matrix(Matrix matrix)
		{
			this.SetByMatrix(matrix);
		}

		#endregion

		#region Operatoren

		public static Matrix operator *(Matrix lhs, Matrix rhs)
		{
			return new Matrix()
			{
				m00 = (lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20 + lhs.m03 * rhs.m30),
				m01 = (lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21 + lhs.m03 * rhs.m31),
				m02 = (lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22 + lhs.m03 * rhs.m32),
				m03 = (lhs.m00 * rhs.m03 + lhs.m01 * rhs.m13 + lhs.m02 * rhs.m23 + lhs.m03 * rhs.m33),
				m10 = (lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20 + lhs.m13 * rhs.m30),
				m11 = (lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31),
				m12 = (lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32),
				m13 = (lhs.m10 * rhs.m03 + lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33),
				m20 = (lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20 + lhs.m23 * rhs.m30),
				m21 = (lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31),
				m22 = (lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32),
				m23 = (lhs.m20 * rhs.m03 + lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33),
				m30 = (lhs.m30 * rhs.m00 + lhs.m31 * rhs.m10 + lhs.m32 * rhs.m20 + lhs.m33 * rhs.m30),
				m31 = (lhs.m30 * rhs.m01 + lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31),
				m32 = (lhs.m30 * rhs.m02 + lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32),
				m33 = (lhs.m30 * rhs.m03 + lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33)
			};
		}

		public static Vector4 operator *(Matrix lhs, Vector4 v)
		{
			Vector4 vector4 = new Vector4();
			vector4.x = (lhs.m00 * v.x + lhs.m01 * v.y + lhs.m02 * v.z + lhs.m03 * v.w);
			vector4.y = (lhs.m10 * v.x + lhs.m11 * v.y + lhs.m12 * v.z + lhs.m13 * v.w);
			vector4.z = (lhs.m20 * v.x + lhs.m21 * v.y + lhs.m22 * v.z + lhs.m23 * v.w);
			vector4.w = (lhs.m30 * v.x + lhs.m31 * v.y + lhs.m32 * v.z + lhs.m33 * v.w);
			return vector4;
		}

		//public static bool operator ==(Matrix lhs, Matrix rhs)
		//{
		//	return lhs.GetColumn(0) == rhs.GetColumn(0) && lhs.GetColumn(1) == rhs.GetColumn(1) && lhs.GetColumn(2) == rhs.GetColumn(2) && lhs.GetColumn(3) == rhs.GetColumn(3);
		//}

		//public static bool operator !=(Matrix lhs, Matrix rhs)
		//{
		//	return !(lhs == rhs);
		//}

		#endregion

		public void SetByMatrix(Matrix matrix)
		{
			if (matrix == null)
				return;

			this.m00 = matrix.m00;
			this.m10 = matrix.m10;
			this.m20 = matrix.m20;
			this.m30 = matrix.m30;
			this.m01 = matrix.m01;
			this.m11 = matrix.m11;
			this.m21 = matrix.m21;
			this.m31 = matrix.m31;
			this.m02 = matrix.m02;
			this.m12 = matrix.m12;
			this.m22 = matrix.m22;
			this.m32 = matrix.m32;
			this.m03 = matrix.m03;
			this.m13 = matrix.m13;
			this.m23 = matrix.m23;
			this.m33 = matrix.m33;
		}

		public Vector4 GetColumn(int i)
		{
			return new Vector4(this[0, i], this[1, i], this[2, i], this[3, i]);
		}

		public Vector4 GetRow(int i)
		{
			return new Vector4(this[i, 0], this[i, 1], this[i, 2], this[i, 3]);
		}

		public void SetColumn(int i, Vector4 v)
		{
			this[0, i] = v.x;
			this[1, i] = v.y;
			this[2, i] = v.z;
			this[3, i] = v.w;
		}

		public void SetRow(int i, Vector4 v)
		{
			this[i, 0] = v.x;
			this[i, 1] = v.y;
			this[i, 2] = v.z;
			this[i, 3] = v.w;
		}

		//Invertieren
		public void Invert()
		{
			Matrix tempMat = new Matrix
				 (this.m00, this.m10, this.m20, this.m30,
				  this.m01, this.m11, this.m21, this.m31,
				  this.m02, this.m12, this.m22, this.m32,
				  this.m03, this.m13, this.m23, this.m33);

			int[] ipvt = new int[4] { 0, 1, 2, 3 };
			int iDim = 4;

			for (int i1 = 0; i1 < iDim; i1++)
			{
				float ftemp = 0.0f;
				int im = i1;
				for (int i2 = i1; i2 < iDim; i2++)
				{
					double dmax = tempMat[i1, i2];
					if (Math.Abs(dmax) > ftemp)
					{
						ftemp = (float)Math.Abs(dmax);
						im = i2;
					}
				}
				if (im != i1)
				{
					int icpy = ipvt[i1];
					ipvt[i1] = ipvt[im];
					ipvt[im] = icpy;
					for (int i2 = 0; i2 < iDim; i2++)
					{
						ftemp = tempMat[i2, i1];
						tempMat[i2, i1] = tempMat[i2, im];
						tempMat[i2, im] = ftemp;
					}
				}
				float ffak = 1.0f / tempMat[i1, i1];
				for (int i2 = 0; i2 < i1; i2++)
				{
					float fcpy = tempMat[i2, i1] * ffak;
					for (int i3 = 0; i3 < iDim; i3++)
						tempMat[i2, i3] -= tempMat[i1, i3] * fcpy;
					tempMat[i2, i1] = fcpy;
				}
				for (int i2 = i1 + 1; i2 < iDim; i2++)
				{
					float fcpy = tempMat[i2, i1] * ffak;
					for (int i3 = 0; i3 < iDim; i3++)
						tempMat[i2, i3] -= tempMat[i1, i3] * fcpy;
					tempMat[i2, i1] = fcpy;
				}
				for (int i3 = 0; i3 < iDim; i3++)
					tempMat[i1, i3] = -tempMat[i1, i3] * ffak;
				tempMat[i1, i1] = ffak;
			}

			for (int i1 = 0; i1 < iDim; i1++)
			{
				for (int i2 = 0; i2 < iDim; i2++)
				{
					this[ipvt[i1], i2] = tempMat[i1, i2];
				}
			}
		}

		/// <summary>
		/// Einheitsmatrix festlegen
		/// </summary>
		public void SetToUnit()
		{
			this.m00 = 1;
			this.m01 = 0;
			this.m02 = 0;
			this.m03 = 0;
			this.m10 = 0;
			this.m11 = 1;
			this.m12 = 0;
			this.m13 = 0;
			this.m20 = 0;
			this.m21 = 0;
			this.m22 = 1;
			this.m23 = 0;
			this.m30 = 0;
			this.m31 = 0;
			this.m32 = 0;
			this.m33 = 1;
		}

		/// <summary>
		/// Prüft, ob eine Einheitsmatrix vorliegt
		/// </summary>
		public bool IsUnitMatrix()
		{
			if (this.m00.Equals(1) && this.m10.Equals(0) && this.m20.Equals(0) && this.m30.Equals(0) &&
				this.m01.Equals(0) && this.m11.Equals(1) && this.m21.Equals(0) && this.m31.Equals(0) &&
				this.m02.Equals(0) && this.m12.Equals(0) && this.m22.Equals(1) && this.m32.Equals(0) &&
				this.m03.Equals(0) && this.m13.Equals(0) && this.m23.Equals(0) && this.m33.Equals(1))
				return true;
			return false;
		}

		public bool IsZeroMatrix()
		{
			if (this.m00.Equals(0) && this.m10.Equals(0) && this.m20.Equals(0) && this.m30.Equals(0) &&
				this.m01.Equals(0) && this.m11.Equals(0) && this.m21.Equals(0) && this.m31.Equals(0) &&
				this.m02.Equals(0) && this.m12.Equals(0) && this.m22.Equals(0) && this.m32.Equals(0) &&
				this.m03.Equals(0) && this.m13.Equals(0) && this.m23.Equals(0) && this.m33.Equals(0))
				return true;
			return false;
		}

		public bool IsNaNMatrix()
		{
			if (this.m00.Equals(float.NaN) && this.m10.Equals(float.NaN) && this.m20.Equals(float.NaN) && this.m30.Equals(float.NaN) &&
				this.m01.Equals(float.NaN) && this.m11.Equals(float.NaN) && this.m21.Equals(float.NaN) && this.m31.Equals(float.NaN) &&
				this.m02.Equals(float.NaN) && this.m12.Equals(float.NaN) && this.m22.Equals(float.NaN) && this.m32.Equals(float.NaN) &&
				this.m03.Equals(float.NaN) && this.m13.Equals(float.NaN) && this.m23.Equals(float.NaN) && this.m33.Equals(float.NaN))
				return true;
			return false;
		}

		public static int Jacobi3(Matrix evalMat, out Matrix evecMat)
		{
			int iRet = 0;
			evecMat = new Matrix();

			float s;
			bool bTausch;
			const int maxit = 20;

			// Initialisierung
			int it = 0;     //Anzahl Iterationen
			float dnorma = 0.0f;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < i; j++)
				{
					evecMat[i, j] = 0.0f;
					evecMat[j, i] = 0.0f;
					dnorma = Math.Max(dnorma, Math.Abs(evalMat[i, j]));
				}
				evecMat[i, i] = 1.0f;
			}
			float eps = 3 * dnorma * (float)1.0E-16;
			float eps2 = eps * eps;

			// Iterative Berechnung der Eigenwerte und Eigenvektoren
			float[,] a2 = new float[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

		m30:
			it += 1;
			if (it > maxit)
			{
				iRet = 1;
				goto m120;
			}
			s = 0.0f;
			for (int i = 1; i < 3; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (Math.Abs(evalMat[i, j]) <= eps) evalMat[i, j] = 0.0f;
					s = s + evalMat[i, j] * evalMat[i, j];
				}
			}
			if (2.0 * s <= eps2) goto m120;     // Ende Iteration
			for (int p = 0; p < 2; p++)
			{
				for (int q = p + 1; q < 3; q++)
				{
					if (Math.Abs(evalMat[q, p]) < eps)
						continue;
					int r = p + 1;
					if (r == q)
						r++;
					if (r >= 3)
						r = 0;
					float theta = 0.5f * (evalMat[q, q] - evalMat[p, p]) / evalMat[q, p];
					float t = 1.0f;
					if (Math.Abs(theta) > 1.0E-16)
					{
						t = 1.0f / (float)(Math.Abs(theta) + Math.Sqrt(1.0 + theta * theta));
						if (theta < 0.0) t = -t;
					}
					float cs = 1.0f / (float)Math.Sqrt(1.0f + t * t);
					float sn = cs * t;
					float tau = (float)sn / (1.0f + cs);
					float h = evalMat[q, p] * t;
					a2[p, p] = evalMat[p, p] - h;
					a2[q, q] = evalMat[q, q] + h;
					a2[q, p] = a2[p, q] = 0.0f;
					a2[p, r] = a2[r, p] = evalMat[p, r] - sn * (evalMat[q, r] + tau * evalMat[p, r]);
					a2[q, r] = a2[r, q] = evalMat[q, r] + sn * (evalMat[p, r] - tau * evalMat[q, r]);
					a2[r, r] = evalMat[r, r];
					evalMat[0, 0] = a2[0, 0];
					evalMat[0, 1] = a2[0, 1];
					evalMat[0, 2] = a2[0, 2];
					evalMat[1, 0] = a2[1, 0];
					evalMat[1, 1] = a2[1, 1];
					evalMat[1, 2] = a2[1, 2];
					evalMat[2, 0] = a2[2, 0];
					evalMat[2, 1] = a2[2, 1];
					evalMat[2, 2] = a2[2, 2];

					for (int j = 0; j < 3; j++)
					{
						h = cs * evecMat[j, p] - sn * evecMat[j, q];
						evecMat[j, q] = sn * evecMat[j, p] + cs * evecMat[j, q];
						evecMat[j, p] = h;
					}
				}
			}
			goto m30;

		// Ergebnis ordnen
		m120:
			bTausch = false;
			for (int i = 1; i < 3; i++)
			{
				int im1 = i - 1;
				if (evalMat[im1, im1] >= evalMat[i, i])
					continue;
				float h = evalMat[im1, im1];
				evalMat[im1, im1] = evalMat[i, i];
				evalMat[i, i] = h;
				for (int j = 0; j < 3; j++)
				{
					h = evecMat[j, im1];
					evecMat[j, im1] = evecMat[j, i];
					evecMat[j, i] = h;
				}
				bTausch = true;
			}
			if (bTausch) goto m120;

			if (Math.Abs(evalMat[2, 2] - evalMat[1, 1]) <= eps)
				iRet = 2;

			return iRet;
		}
	}
}
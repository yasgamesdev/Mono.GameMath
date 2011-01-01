// 
// Vector2.cs
//  
// Author:
//       Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (c) 2010 Novell, Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Mono.GameMath;

namespace Benchmark
{
	public static class Vector2Test
	{
		#region Arithmetic
		
		public static void Add (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				result = Vector2.Add (result, a);
			}
		}
		
		public static void AddRef (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				Vector2.Add (ref result, ref a, out result);
			}
		}
		
		public static void DivideScalar (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = Vector2.Divide (result, 0.9f);
			}
		}
		
		public static void DivideScalarRef (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				Vector2.Divide (ref result, 0.9f, out result);
			}
		}
		
		public static void Divide (int times)
		{
			Vector2 a = new Vector2 (0.9f, 0.91f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = Vector2.Divide (result, a);
			}
		}
		
		public static void DivideRef (int times)
		{
			Vector2 a = new Vector2 (0.9f, 0.91f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				Vector2.Divide (ref result, ref a, out result);
			}
		}
		
		public static void MultiplyScalar (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = Vector2.Multiply (result, 1.1f);
			}
		}
		
		public static void MultiplyScalarRef (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				Vector2.Multiply (ref result, 1.1f, out result);
			}
		}
		
		public static void Multiply (int times)
		{
			Vector2 a = new Vector2 (1.1f, 1.11f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = Vector2.Multiply (result, a);
			}
		}
		
		public static void MultiplyRef (int times)
		{
			Vector2 a = new Vector2 (1.1f, 1.11f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				Vector2.Multiply (ref result, ref a, out result);
			}
		}
		
		public static void Negate (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = Vector2.Negate (result);
			}
		}
		
		public static void NegateRef (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				Vector2.Negate (ref result, out result);
			}
		}
		
		public static void Subtract (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				result = Vector2.Subtract (result, a);
			}
		}
		
		public static void SubtractRef (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				Vector2.Subtract (ref result, ref a, out result);
			}
		}
		
		#endregion
		
		#region Operator overloads
		
		public static void OpAdd (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				result = result + a;
			}
		}
		
		public static void OpDivideScalar (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = result / 0.9f;
			}
		}
		
		public static void OpDivide (int times)
		{
			Vector2 a = new Vector2 (0.9f, 0.91f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = result / a;
			}
		}
		
		public static void OpMultiply (int times)
		{
			Vector2 a = new Vector2 (1.1f, 1.11f);
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = result * a;
			}
		}
		
		public static void OpMultiplyScalar (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = result * 1.1f;
			}
		}
		
		public static void OpMultiplyScalarPre (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = 1.1f * result;
			}
		}
		
		public static void OpSubtract (int times)
		{
			Vector2 a = new Vector2 (1f, 2f);
			Vector2 result = Vector2.Zero;
			for (int i = 0; i < times; i++) {
				result =  result - a;
			}
		}
		
		public static void OpNegate (int times)
		{
			Vector2 result = new Vector2 (1f, 2f);
			for (int i = 0; i < times; i++) {
				result = -result;
			}
		}
		
		#endregion
	}
}
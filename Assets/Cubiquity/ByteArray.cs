﻿using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

namespace Cubiquity
{
	public struct ByteArray
	{
		private ulong data;
		
		public byte this[int i]
		{
			get
			{
				return (byte)(getEightBitsAt(i * 8));
			}
			set
			{
				setEightBitsAt(i * 8, value);
			}
		}
		
		private ulong getEightBitsAt(int offset)
		{
			ulong mask = 0x000000FF;
			ulong result = data;
			result >>= offset;
			result &= mask;
			return result;
		}
		
		private void setEightBitsAt(int offset, ulong val)
		{
			ulong mask = 0x000000FF;
			int shift = offset;
			mask <<= shift;
			
			data = (uint)(data & (uint)(~mask));
			
			val <<= shift;
			val &= mask;
			
			data |= val;
		}
	}
}
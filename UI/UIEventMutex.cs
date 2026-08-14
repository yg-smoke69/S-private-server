using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2004145")]
public class UIEventMutex
{
	[Token(Token = "0x2004146")]
	private sealed class _003CSetMutex_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B650")]
		[FieldOffset(Offset = "0x8")]
		internal int Id;

		[Token(Token = "0x401B651")]
		[FieldOffset(Offset = "0xC")]
		internal UIEventMutex _0024this;

		[Token(Token = "0x601AACF")]
		[Address(RVA = "0x1473A94", Offset = "0x1473A94", VA = "0x1473A94")]
		public _003CSetMutex_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601AAD0")]
		[Address(RVA = "0x1473BEC", Offset = "0x1473BEC", VA = "0x1473BEC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B64F")]
	[FieldOffset(Offset = "0x8")]
	private HashSet<int> m_MutexList;

	[Token(Token = "0x601AAC9")]
	[Address(RVA = "0x1473784", Offset = "0x1473784", VA = "0x1473784")]
	public UIEventMutex()
	{
	}

	[Token(Token = "0x601AACA")]
	[Address(RVA = "0x1473810", Offset = "0x1473810", VA = "0x1473810")]
	public bool IsMutex(int Id)
	{
		return default(bool);
	}

	[Token(Token = "0x601AACB")]
	[Address(RVA = "0x14738DC", Offset = "0x14738DC", VA = "0x14738DC")]
	public void SetMutex(int Id, uint autoReleaseTimeMs = 0u)
	{
	}

	[Token(Token = "0x601AACC")]
	[Address(RVA = "0x1473A9C", Offset = "0x1473A9C", VA = "0x1473A9C")]
	public void ReleaseMutex(int Id)
	{
	}

	[Token(Token = "0x601AACD")]
	[Address(RVA = "0x1473B1C", Offset = "0x1473B1C", VA = "0x1473B1C")]
	public bool Check(int Id, Action callback, uint autoReleaseTimeMs = 0u)
	{
		return default(bool);
	}

	[Token(Token = "0x601AACE")]
	[Address(RVA = "0x1473B74", Offset = "0x1473B74", VA = "0x1473B74")]
	public void Clear()
	{
	}
}

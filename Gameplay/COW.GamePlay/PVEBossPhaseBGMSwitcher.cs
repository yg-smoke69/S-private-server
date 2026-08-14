using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000A78")]
public class PVEBossPhaseBGMSwitcher : MonoBehaviour
{
	[Token(Token = "0x2000A79")]
	private sealed class MODHCHKNGMO : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005C50")]
		[FieldOffset(Offset = "0x8")]
		internal List<BossBGMInfo> AIOEIAIIPGO;

		[Token(Token = "0x4005C51")]
		[FieldOffset(Offset = "0xC")]
		internal List<BossBGMInfo>.Enumerator APEFBLFMFJC;

		[Token(Token = "0x4005C52")]
		[FieldOffset(Offset = "0x1C")]
		internal BossBGMInfo GOEKLLEKLGD;

		[Token(Token = "0x4005C53")]
		[FieldOffset(Offset = "0x20")]
		internal ResourceID OOBOONAGAGF;

		[Token(Token = "0x4005C54")]
		[FieldOffset(Offset = "0x24")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4005C55")]
		[FieldOffset(Offset = "0x28")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4005C56")]
		[FieldOffset(Offset = "0x2C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000638")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60050AC")]
			[Address(RVA = "0x1669E54", Offset = "0x1669E54", VA = "0x1669E54", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000639")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60050AD")]
			[Address(RVA = "0x1669E5C", Offset = "0x1669E5C", VA = "0x1669E5C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x1669A90", Offset = "0x1669A90", VA = "0x1669A90")]
		public MODHCHKNGMO()
		{
		}

		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x1669A98", Offset = "0x1669A98", VA = "0x1669A98", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x1669E64", Offset = "0x1669E64", VA = "0x1669E64", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60050AF")]
		[Address(RVA = "0x1669EE4", Offset = "0x1669EE4", VA = "0x1669EE4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005C4D")]
	[FieldOffset(Offset = "0xC")]
	private int KDADIHAAEED;

	[Token(Token = "0x4005C4E")]
	[FieldOffset(Offset = "0x10")]
	public List<BossPhaseBGMInfo> phaseBgmInfos;

	[Token(Token = "0x4005C4F")]
	[FieldOffset(Offset = "0x14")]
	private IEnumerator MEJCJIEOFKO;

	[Token(Token = "0x60050A7")]
	[Address(RVA = "0x1669670", Offset = "0x1669670", VA = "0x1669670")]
	public PVEBossPhaseBGMSwitcher()
	{
	}

	[Token(Token = "0x60050A8")]
	[Address(RVA = "0x1669680", Offset = "0x1669680", VA = "0x1669680")]
	public void EnterPhase(int KPIAGKHAPOP)
	{
	}

	[Token(Token = "0x60050A9")]
	[Address(RVA = "0x16699BC", Offset = "0x16699BC", VA = "0x16699BC")]
	private IEnumerator HIENGLAILHP(List<BossBGMInfo> AIOEIAIIPGO)
	{
		return null;
	}
}

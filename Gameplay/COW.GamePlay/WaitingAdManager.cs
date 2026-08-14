using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200080C")]
public class WaitingAdManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200080D")]
	public class LEDList
	{
		[Token(Token = "0x40050B4")]
		[FieldOffset(Offset = "0x8")]
		public List<MeshRenderer> LEDs;

		[Token(Token = "0x600335A")]
		[Address(RVA = "0x26F4430", Offset = "0x26F4430", VA = "0x26F4430")]
		public LEDList()
		{
		}
	}

	[Token(Token = "0x200080E")]
	private sealed class MPCLFNGJJAH
	{
		[Token(Token = "0x40050B5")]
		[FieldOffset(Offset = "0x8")]
		internal Material HMNKPBLBCOC;

		[Token(Token = "0x600335B")]
		[Address(RVA = "0x26F427C", Offset = "0x26F427C", VA = "0x26F427C")]
		public MPCLFNGJJAH()
		{
		}

		[Token(Token = "0x600335C")]
		[Address(RVA = "0x26F4438", Offset = "0x26F4438", VA = "0x26F4438")]
		internal void CHOPCLCOBKC(Texture2D KANJOBFCAIN)
		{
		}
	}

	[Token(Token = "0x200080F")]
	private sealed class BNHHJDHIMOM
	{
		[Token(Token = "0x40050B6")]
		[FieldOffset(Offset = "0x8")]
		internal List<MeshRenderer> EKBBPNDDHAK;

		[Token(Token = "0x600335D")]
		[Address(RVA = "0x26F4284", Offset = "0x26F4284", VA = "0x26F4284")]
		public BNHHJDHIMOM()
		{
		}

		[Token(Token = "0x600335E")]
		[Address(RVA = "0x26F42E0", Offset = "0x26F42E0", VA = "0x26F42E0")]
		internal void CHOPCLCOBKC(Texture2D KANJOBFCAIN)
		{
		}
	}

	[Token(Token = "0x40050B1")]
	[FieldOffset(Offset = "0xC")]
	public MeshRenderer TowerTopLED;

	[Token(Token = "0x40050B2")]
	[FieldOffset(Offset = "0x10")]
	public MeshRenderer HallCentreLED;

	[Token(Token = "0x40050B3")]
	[FieldOffset(Offset = "0x14")]
	public List<LEDList> HallSideHEDList;

	[Token(Token = "0x6003357")]
	[Address(RVA = "0x26F3594", Offset = "0x26F3594", VA = "0x26F3594")]
	public WaitingAdManager()
	{
	}

	[Token(Token = "0x6003358")]
	[Address(RVA = "0x26F3620", Offset = "0x26F3620", VA = "0x26F3620")]
	private void Start()
	{
	}

	[Token(Token = "0x6003359")]
	[Address(RVA = "0x26F428C", Offset = "0x26F428C", VA = "0x26F428C")]
	private void GEAKHDALOHC(Texture2D KANJOBFCAIN)
	{
	}
}

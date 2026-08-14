using System;
using System.IO;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
[Token(Token = "0x2003F5A")]
public class GrassInst : CEJMEBEOMIJ
{
	[Token(Token = "0x401AB49")]
	[FieldOffset(Offset = "0x8")]
	public byte m_spriteID;

	[Token(Token = "0x401AB4A")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 m_pos;

	[Token(Token = "0x401AB4B")]
	[FieldOffset(Offset = "0x18")]
	public uint[] m_NormalAndRotation;

	[Token(Token = "0x6019CBB")]
	[Address(RVA = "0x25A929C", Offset = "0x25A929C", VA = "0x25A929C")]
	public GrassInst()
	{
	}

	[Token(Token = "0x6019CBC")]
	[Address(RVA = "0x25A9310", Offset = "0x25A9310", VA = "0x25A9310")]
	public static void AHCBMLHIAFE(uint[] CLBPECNABJF, ref Vector3 MLNCIOAIDHL)
	{
	}

	[Token(Token = "0x6019CBD")]
	[Address(RVA = "0x25A9424", Offset = "0x25A9424", VA = "0x25A9424")]
	public static void PHHNIOFOIBP(uint[] CLBPECNABJF, ref float IOOPPDAAMEP)
	{
	}

	[Token(Token = "0x6019CBE")]
	[Address(RVA = "0x25A9508", Offset = "0x25A9508", VA = "0x25A9508")]
	public static void BJBJIGKENHA(uint[] CLBPECNABJF, ref float IIGIENFDGBK)
	{
	}

	[Token(Token = "0x6019CBF")]
	[Address(RVA = "0x25A95C4", Offset = "0x25A95C4", VA = "0x25A95C4")]
	public static void CAEHFAKMAOH(ref uint[] CLBPECNABJF, float IIGIENFDGBK)
	{
	}

	[Token(Token = "0x6019CC0")]
	[Address(RVA = "0x25A96F8", Offset = "0x25A96F8", VA = "0x25A96F8")]
	public static void AOGHNNEAFAF(uint[] CLBPECNABJF, ref Vector3 MLNCIOAIDHL, ref Quaternion FHOOEHJBEDL)
	{
	}

	[Token(Token = "0x6019CC1")]
	[Address(RVA = "0x25A9904", Offset = "0x25A9904", VA = "0x25A9904")]
	public static void GHJBEKFDJBA(Vector3 MLNCIOAIDHL, Quaternion FHOOEHJBEDL, float IOOPPDAAMEP, ref uint[] CLBPECNABJF)
	{
	}

	[Token(Token = "0x6019CC2")]
	[Address(RVA = "0x25A9B0C", Offset = "0x25A9B0C", VA = "0x25A9B0C", Slot = "4")]
	protected override void IKMLPCLJFBF(ref BinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6019CC3")]
	[Address(RVA = "0x25A9C7C", Offset = "0x25A9C7C", VA = "0x25A9C7C", Slot = "5")]
	protected override void KAEAEDKPFGK(ref BinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6019CC4")]
	[Address(RVA = "0x25A9DCC", Offset = "0x25A9DCC", VA = "0x25A9DCC", Slot = "6")]
	protected override void PCKFEGCCEMD(JsonData MIBCHPEMKBF)
	{
	}

	[Token(Token = "0x6019CC5")]
	[Address(RVA = "0x25A9FCC", Offset = "0x25A9FCC", VA = "0x25A9FCC", Slot = "7")]
	protected override void FNCFOKEBNOD(ref JsonWriter NNPGNFBKEMM)
	{
	}
}

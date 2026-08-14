using System;
using System.IO;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
[Token(Token = "0x2003F57")]
public class GrassCell : CEJMEBEOMIJ
{
	[Token(Token = "0x401AB45")]
	[FieldOffset(Offset = "0x8")]
	public GrassSubCell[] m_subCells;

	[Token(Token = "0x401AB46")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 m_position;

	[Token(Token = "0x401AB47")]
	[FieldOffset(Offset = "0x18")]
	public bool m_hassGrass;

	[Token(Token = "0x6019CA1")]
	[Address(RVA = "0x25A898C", Offset = "0x25A898C", VA = "0x25A898C")]
	public GrassCell()
	{
	}

	[Token(Token = "0x6019CA2")]
	[Address(RVA = "0x25A8994", Offset = "0x25A8994", VA = "0x25A8994")]
	public GrassCell(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6019CA3")]
	[Address(RVA = "0x25A8A28", Offset = "0x25A8A28", VA = "0x25A8A28", Slot = "4")]
	protected override void IKMLPCLJFBF(ref BinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6019CA4")]
	[Address(RVA = "0x25A8C7C", Offset = "0x25A8C7C", VA = "0x25A8C7C", Slot = "5")]
	protected override void KAEAEDKPFGK(ref BinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6019CA5")]
	[Address(RVA = "0x25A8DB4", Offset = "0x25A8DB4", VA = "0x25A8DB4", Slot = "6")]
	protected override void PCKFEGCCEMD(JsonData MIBCHPEMKBF)
	{
	}

	[Token(Token = "0x6019CA6")]
	[Address(RVA = "0x25A9028", Offset = "0x25A9028", VA = "0x25A9028", Slot = "7")]
	protected override void FNCFOKEBNOD(ref JsonWriter NNPGNFBKEMM)
	{
	}
}

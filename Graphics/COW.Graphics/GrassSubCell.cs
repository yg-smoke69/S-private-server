using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
[Token(Token = "0x2003F56")]
public class GrassSubCell : CEJMEBEOMIJ
{
	[Token(Token = "0x401AB3F")]
	[FieldOffset(Offset = "0x8")]
	public List<int> m_grassList;

	[Token(Token = "0x401AB40")]
	[FieldOffset(Offset = "0xC")]
	public List<int> m_bushList;

	[Token(Token = "0x401AB41")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_position;

	[Token(Token = "0x401AB42")]
	[FieldOffset(Offset = "0x1C")]
	public int m_vertCount;

	[Token(Token = "0x401AB43")]
	[FieldOffset(Offset = "0x20")]
	public bool m_hassGrass;

	[NonSerialized]
	[Token(Token = "0x401AB44")]
	[FieldOffset(Offset = "0x24")]
	public int m_updateCount;

	[Token(Token = "0x6019C9B")]
	[Address(RVA = "0x25A8BD8", Offset = "0x25A8BD8", VA = "0x25A8BD8")]
	public GrassSubCell()
	{
	}

	[Token(Token = "0x6019C9C")]
	[Address(RVA = "0x25AA330", Offset = "0x25AA330", VA = "0x25AA330")]
	public GrassSubCell(Vector3 ACCOJJMKKPM, int ECJBMJPEOFC = 0)
	{
	}

	[Token(Token = "0x6019C9D")]
	[Address(RVA = "0x25AA404", Offset = "0x25AA404", VA = "0x25AA404", Slot = "4")]
	protected override void IKMLPCLJFBF(ref BinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6019C9E")]
	[Address(RVA = "0x25AA634", Offset = "0x25AA634", VA = "0x25AA634", Slot = "5")]
	protected override void KAEAEDKPFGK(ref BinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6019C9F")]
	[Address(RVA = "0x25AA908", Offset = "0x25AA908", VA = "0x25AA908", Slot = "6")]
	protected override void PCKFEGCCEMD(JsonData MIBCHPEMKBF)
	{
	}

	[Token(Token = "0x6019CA0")]
	[Address(RVA = "0x25AAC2C", Offset = "0x25AAC2C", VA = "0x25AAC2C", Slot = "7")]
	protected override void FNCFOKEBNOD(ref JsonWriter NNPGNFBKEMM)
	{
	}
}

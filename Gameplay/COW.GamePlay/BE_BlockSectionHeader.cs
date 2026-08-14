using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C05")]
public class BE_BlockSectionHeader : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4006393")]
	[FieldOffset(Offset = "0xC")]
	private UIWidget PEAFOBMHLBO;

	[Token(Token = "0x4006394")]
	[FieldOffset(Offset = "0x10")]
	public float minHeight;

	[Token(Token = "0x4006395")]
	[FieldOffset(Offset = "0x14")]
	public Transform ElementStartPos;

	[Token(Token = "0x4006396")]
	[FieldOffset(Offset = "0x18")]
	public EJPDJDBMLIN m_BelongBlock;

	[Token(Token = "0x4006397")]
	[FieldOffset(Offset = "0x1C")]
	private List<IPIKJNGGEOB> CFLAGGOBJDJ;

	[Token(Token = "0x4006398")]
	[FieldOffset(Offset = "0x20")]
	public BE_BlockSectionHeader_AdditionalBtn AdditionalBtn;

	[Token(Token = "0x4006399")]
	[FieldOffset(Offset = "0x24")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x400639A")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BGSprite;

	[Token(Token = "0x400639B")]
	[FieldOffset(Offset = "0x2C")]
	private BoxCollider BLIKPEIABBO;

	[Token(Token = "0x400639C")]
	[FieldOffset(Offset = "0x30")]
	public int MinHeight;

	[Token(Token = "0x400639D")]
	[FieldOffset(Offset = "0x34")]
	public int MinWidth;

	[Token(Token = "0x400639E")]
	[FieldOffset(Offset = "0x38")]
	public int UpDownMarginSize;

	[Token(Token = "0x400639F")]
	[FieldOffset(Offset = "0x3C")]
	public int XOffset;

	[Token(Token = "0x40063A0")]
	[FieldOffset(Offset = "0x40")]
	public int YOffset;

	[Token(Token = "0x17000780")]
	public EJPDJDBMLIN EKDOECAENMH
	{
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x1609344", Offset = "0x1609344", VA = "0x1609344", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x16052F0", Offset = "0x16052F0", VA = "0x16052F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000781")]
	public Vector2 AEOEMDPAGHB
	{
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x1605D28", Offset = "0x1605D28", VA = "0x1605D28", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x160939C", Offset = "0x160939C", VA = "0x160939C", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000782")]
	public List<IPIKJNGGEOB> DAJDOGOPJKI
	{
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x16095D4", Offset = "0x16095D4", VA = "0x16095D4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000783")]
	public Transform GEEGEDPOLAH
	{
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0x160962C", Offset = "0x160962C", VA = "0x160962C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000784")]
	public UISprite EMJGFDPBDLK
	{
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x1609684", Offset = "0x1609684", VA = "0x1609684", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000785")]
	public BoxCollider ALDDOJNFKBN
	{
		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x16096DC", Offset = "0x16096DC", VA = "0x16096DC", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005B47")]
	[Address(RVA = "0x1609290", Offset = "0x1609290", VA = "0x1609290")]
	public BE_BlockSectionHeader()
	{
	}

	[Token(Token = "0x6005B50")]
	[Address(RVA = "0x1609734", Offset = "0x1609734", VA = "0x1609734")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B51")]
	[Address(RVA = "0x1605F60", Offset = "0x1605F60", VA = "0x1605F60", Slot = "11")]
	public void UpdateColorAndBG(Color MGAOFBNFAKF)
	{
	}

	[Token(Token = "0x6005B52")]
	[Address(RVA = "0x16062E0", Offset = "0x16062E0", VA = "0x16062E0", Slot = "12")]
	public void SetHeaderWidghtDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD)
	{
	}

	[Token(Token = "0x6005B53")]
	[Address(RVA = "0x1609A04", Offset = "0x1609A04", VA = "0x1609A04", Slot = "13")]
	public void UpdateHeaderSize()
	{
	}
}

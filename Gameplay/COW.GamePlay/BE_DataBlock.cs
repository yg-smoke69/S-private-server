using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB6")]
public class BE_DataBlock : BE_Base, _Attribute
{
	[Token(Token = "0x4006257")]
	[FieldOffset(Offset = "0x11")]
	public bool IsConstVal;

	[Token(Token = "0x4006258")]
	[FieldOffset(Offset = "0x14")]
	public Transform ElementStartPos;

	[Token(Token = "0x4006259")]
	[FieldOffset(Offset = "0x18")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x400625A")]
	[FieldOffset(Offset = "0x1C")]
	private List<IPIKJNGGEOB> CFLAGGOBJDJ;

	[Token(Token = "0x400625B")]
	[FieldOffset(Offset = "0x20")]
	private BE_BlockSectionHeader_Slot DGKJJIDKBJI;

	[Token(Token = "0x400625C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite m_HightLightSprite;

	[Token(Token = "0x400625D")]
	[FieldOffset(Offset = "0x28")]
	public BE_DataSpot OutSingle;

	[Token(Token = "0x400625E")]
	[FieldOffset(Offset = "0x2C")]
	public BE_DataSpot OutArray;

	[Token(Token = "0x400625F")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ArrowSingle;

	[Token(Token = "0x4006260")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ArrowArray1;

	[Token(Token = "0x4006261")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ArrowArray2;

	[Token(Token = "0x4006262")]
	[FieldOffset(Offset = "0x3C")]
	private bool HFCBOPEGAHN;

	[Token(Token = "0x4006263")]
	[FieldOffset(Offset = "0x3D")]
	public bool IsErrorBlock;

	[Token(Token = "0x4006264")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_BGSprite;

	[Token(Token = "0x4006265")]
	[FieldOffset(Offset = "0x44")]
	private UIWidget PEAFOBMHLBO;

	[Token(Token = "0x4006266")]
	[FieldOffset(Offset = "0x48")]
	private List<BE_SlotDragDropItem> OEKOCGKMOEC;

	[Token(Token = "0x4006267")]
	[FieldOffset(Offset = "0x4C")]
	public int MinHeight;

	[Token(Token = "0x4006268")]
	[FieldOffset(Offset = "0x50")]
	public int MinWidth;

	[Token(Token = "0x4006269")]
	[FieldOffset(Offset = "0x54")]
	public int UpDownMarginSize;

	[Token(Token = "0x400626A")]
	[FieldOffset(Offset = "0x58")]
	public int XOffset;

	[Token(Token = "0x400626B")]
	[FieldOffset(Offset = "0x5C")]
	public int YOffset;

	[Token(Token = "0x400626C")]
	[FieldOffset(Offset = "0x60")]
	public UISprite VariableIcon;

	[Token(Token = "0x400626D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite DeepBG;

	[Token(Token = "0x17000733")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x2D25A3C", Offset = "0x2D25A3C", VA = "0x2D25A3C", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000734")]
	public List<IPIKJNGGEOB> NFPIJCAFMMJ
	{
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0x2D25A94", Offset = "0x2D25A94", VA = "0x2D25A94", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0x2D25AEC", Offset = "0x2D25AEC", VA = "0x2D25AEC", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x17000735")]
	public BE_BlockSectionHeader_Slot HHLBJOKMMGC
	{
		[Token(Token = "0x60058D7")]
		[Address(RVA = "0x2D25B4C", Offset = "0x2D25B4C", VA = "0x2D25B4C", Slot = "13")]
		get
		{
			return null;
		}
		[Token(Token = "0x60058D8")]
		[Address(RVA = "0x2D25BA4", Offset = "0x2D25BA4", VA = "0x2D25BA4", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x17000736")]
	public UISprite MOEGALPADFK
	{
		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x2D25C04", Offset = "0x2D25C04", VA = "0x2D25C04", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000737")]
	public BE_DataSpot CIMOEHHKHIK
	{
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x2D25C5C", Offset = "0x2D25C5C", VA = "0x2D25C5C", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000738")]
	public UISprite KIIGJMBCKDO
	{
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x2D25CB4", Offset = "0x2D25CB4", VA = "0x2D25CB4", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000739")]
	public UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x2D25D0C", Offset = "0x2D25D0C", VA = "0x2D25D0C", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073A")]
	public List<BE_SlotDragDropItem> IMIHMFHDOLM
	{
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0x2D25D64", Offset = "0x2D25D64", VA = "0x2D25D64", Slot = "18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60058DE")]
		[Address(RVA = "0x2D25DBC", Offset = "0x2D25DBC", VA = "0x2D25DBC")]
		set
		{
		}
	}

	[Token(Token = "0x60058D3")]
	[Address(RVA = "0x2D25950", Offset = "0x2D25950", VA = "0x2D25950")]
	public BE_DataBlock()
	{
	}

	[Token(Token = "0x60058DF")]
	[Address(RVA = "0x2D25E1C", Offset = "0x2D25E1C", VA = "0x2D25E1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60058E0")]
	[Address(RVA = "0x2D260E8", Offset = "0x2D260E8", VA = "0x2D260E8", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60058E1")]
	[Address(RVA = "0x2D262DC", Offset = "0x2D262DC", VA = "0x2D262DC")]
	public void InitDataBlock()
	{
	}

	[Token(Token = "0x60058E2")]
	[Address(RVA = "0x2D26380", Offset = "0x2D26380", VA = "0x2D26380", Slot = "20")]
	public void UpdateSize()
	{
	}

	[Token(Token = "0x60058E3")]
	[Address(RVA = "0x2D263D4", Offset = "0x2D263D4", VA = "0x2D263D4", Slot = "21")]
	public void SetBGAndColor(Color MGAOFBNFAKF)
	{
	}

	[Token(Token = "0x60058E4")]
	[Address(RVA = "0x2D26518", Offset = "0x2D26518", VA = "0x2D26518", Slot = "22")]
	public void SetBlockWidghtDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD = true)
	{
	}

	[Token(Token = "0x60058E5")]
	[Address(RVA = "0x2D26A84", Offset = "0x2D26A84", VA = "0x2D26A84", Slot = "23")]
	public void UpdateDataBlockSize()
	{
	}

	[Token(Token = "0x60058E6")]
	[Address(RVA = "0x2D25EE8", Offset = "0x2D25EE8", VA = "0x2D25EE8", Slot = "28")]
	public void SetHighLightState(bool GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x60058E7")]
	[Address(RVA = "0x2D27720", Offset = "0x2D27720", VA = "0x2D27720")]
	public void SetErrorSpirte(bool GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x60058E8")]
	[Address(RVA = "0x2D278CC", Offset = "0x2D278CC", VA = "0x2D278CC", Slot = "9")]
	public override void CheckBlockLegalty()
	{
	}

	[Token(Token = "0x60058E9")]
	[Address(RVA = "0x2D27EEC", Offset = "0x2D27EEC", VA = "0x2D27EEC")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x60058EA")]
	[Address(RVA = "0x2D27EF4", Offset = "0x2D27EF4", VA = "0x2D27EF4")]
	public void _003C_003EiFixBaseProxy_CheckBlockLegalty()
	{
	}
}

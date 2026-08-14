using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB3")]
public class BE_Block : MonoBehaviour, _Attribute
{
	[Token(Token = "0x400623D")]
	[FieldOffset(Offset = "0xC")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x400623E")]
	[FieldOffset(Offset = "0x10")]
	public BE_BlockSectionHeader m_Header;

	[Token(Token = "0x400623F")]
	[FieldOffset(Offset = "0x14")]
	private List<BCEILEJONNO> ANNKMHLOHEM;

	[Token(Token = "0x4006240")]
	[FieldOffset(Offset = "0x18")]
	private BCEILEJONNO NGLIIBJMHOG;

	[Token(Token = "0x4006241")]
	[FieldOffset(Offset = "0x1C")]
	private int LEMNAPAAODC;

	[Token(Token = "0x4006242")]
	[FieldOffset(Offset = "0x20")]
	public BE_BlockSpot In;

	[Token(Token = "0x4006243")]
	[FieldOffset(Offset = "0x24")]
	public BE_BlockSpot Out;

	[Token(Token = "0x4006244")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_MidleSprite;

	[Token(Token = "0x4006245")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget PEAFOBMHLBO;

	[Token(Token = "0x4006246")]
	[FieldOffset(Offset = "0x30")]
	public List<UISprite> m_HightLightSprites;

	[Token(Token = "0x4006247")]
	[FieldOffset(Offset = "0x34")]
	public int DefaultMiddleGapHeight;

	[Token(Token = "0x4006248")]
	[FieldOffset(Offset = "0x38")]
	private BodyData PCDMBLBKKGP;

	[Token(Token = "0x4006249")]
	[FieldOffset(Offset = "0x3C")]
	public int OutSpotConvexHeight;

	[Token(Token = "0x17000716")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x600589B")]
		[Address(RVA = "0x16049E8", Offset = "0x16049E8", VA = "0x16049E8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000717")]
	public BE_BlockSectionHeader ABNIOKCINGP
	{
		[Token(Token = "0x600589C")]
		[Address(RVA = "0x1604A40", Offset = "0x1604A40", VA = "0x1604A40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000718")]
	public List<BCEILEJONNO> HDJFDHBLCNH
	{
		[Token(Token = "0x600589D")]
		[Address(RVA = "0x1604A98", Offset = "0x1604A98", VA = "0x1604A98", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600589E")]
		[Address(RVA = "0x1604AF0", Offset = "0x1604AF0", VA = "0x1604AF0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000719")]
	public BCEILEJONNO PGACNNPHAPP
	{
		[Token(Token = "0x600589F")]
		[Address(RVA = "0x1604B50", Offset = "0x1604B50", VA = "0x1604B50", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60058A0")]
		[Address(RVA = "0x1604BA8", Offset = "0x1604BA8", VA = "0x1604BA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700071A")]
	public int GMIOLDCCOAD
	{
		[Token(Token = "0x60058A1")]
		[Address(RVA = "0x1604C08", Offset = "0x1604C08", VA = "0x1604C08", Slot = "11")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60058A2")]
		[Address(RVA = "0x1604C60", Offset = "0x1604C60", VA = "0x1604C60", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x1700071B")]
	public BE_BlockSpot MELDEEECDAK
	{
		[Token(Token = "0x60058A3")]
		[Address(RVA = "0x1604CC0", Offset = "0x1604CC0", VA = "0x1604CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071C")]
	public BE_BlockSpot CIMOEHHKHIK
	{
		[Token(Token = "0x60058A4")]
		[Address(RVA = "0x1604D18", Offset = "0x1604D18", VA = "0x1604D18", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071D")]
	public UISprite PHKJDMHCPLM
	{
		[Token(Token = "0x60058A5")]
		[Address(RVA = "0x1604D70", Offset = "0x1604D70", VA = "0x1604D70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071E")]
	public UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x60058A6")]
		[Address(RVA = "0x1604DC8", Offset = "0x1604DC8", VA = "0x1604DC8", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071F")]
	public List<UISprite> MOEGALPADFK
	{
		[Token(Token = "0x60058A7")]
		[Address(RVA = "0x1604E20", Offset = "0x1604E20", VA = "0x1604E20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000720")]
	public int OGHGGOHAIAA
	{
		[Token(Token = "0x60058A8")]
		[Address(RVA = "0x1604E78", Offset = "0x1604E78", VA = "0x1604E78")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000721")]
	public BodyData ODAIMNGHDIC
	{
		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x1605158", Offset = "0x1605158", VA = "0x1605158", Slot = "15")]
		get
		{
			return null;
		}
		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x16051B0", Offset = "0x16051B0", VA = "0x16051B0", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x600589A")]
	[Address(RVA = "0x160494C", Offset = "0x160494C", VA = "0x160494C")]
	public BE_Block()
	{
	}

	[Token(Token = "0x60058AB")]
	[Address(RVA = "0x1605210", Offset = "0x1605210", VA = "0x1605210")]
	private void Awake()
	{
	}

	[Token(Token = "0x60058AC")]
	[Address(RVA = "0x1605350", Offset = "0x1605350", VA = "0x1605350")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60058AD")]
	[Address(RVA = "0x16055AC", Offset = "0x16055AC", VA = "0x16055AC", Slot = "18")]
	public void UpdateSize()
	{
	}

	[Token(Token = "0x60058AE")]
	[Address(RVA = "0x1605DFC", Offset = "0x1605DFC", VA = "0x1605DFC", Slot = "19")]
	public void SetBGAndColor(Color MGAOFBNFAKF)
	{
	}

	[Token(Token = "0x60058AF")]
	[Address(RVA = "0x1606014", Offset = "0x1606014", VA = "0x1606014", Slot = "20")]
	public void SetBlockWidghtDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD)
	{
	}

	[Token(Token = "0x60058B0")]
	[Address(RVA = "0x16065B0", Offset = "0x16065B0", VA = "0x16065B0", Slot = "21")]
	public void SetHighLightState(bool GLDLCOBLGNF)
	{
	}
}

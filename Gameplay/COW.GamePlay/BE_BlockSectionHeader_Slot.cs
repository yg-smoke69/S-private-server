using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C13")]
public class BE_BlockSectionHeader_Slot : MonoBehaviour, _Attribute
{
	[Token(Token = "0x400642B")]
	[FieldOffset(Offset = "0xC")]
	private UIWidget GKGOLADJHDC;

	[Token(Token = "0x400642C")]
	[FieldOffset(Offset = "0x10")]
	private TypeInfo AECJHDIHLBB;

	[Token(Token = "0x400642D")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget SlotSingle;

	[Token(Token = "0x400642E")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget SlotArray;

	[Token(Token = "0x400642F")]
	[FieldOffset(Offset = "0x20")]
	private EKEOCIDDIFH PJBIKHKBGEK;

	[Token(Token = "0x4006430")]
	[FieldOffset(Offset = "0x24")]
	private EKEOCIDDIFH MFKJLEFDICK;

	[Token(Token = "0x4006431")]
	[FieldOffset(Offset = "0x28")]
	private KMMOEDDCDFM IKDFPILOJPC;

	[Token(Token = "0x4006432")]
	[FieldOffset(Offset = "0x2C")]
	private ValueData OOFCHNNKOFD;

	[Token(Token = "0x4006433")]
	[FieldOffset(Offset = "0x30")]
	public BlockData BlockData;

	[Token(Token = "0x4006434")]
	[FieldOffset(Offset = "0x34")]
	public int ValueIndex;

	[Token(Token = "0x4006435")]
	[FieldOffset(Offset = "0x38")]
	public UISprite HighLightSprite;

	[Token(Token = "0x4006436")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpotSprite;

	[Token(Token = "0x4006437")]
	[FieldOffset(Offset = "0x40")]
	public BE_SlotSpot SpotInSingle;

	[Token(Token = "0x4006438")]
	[FieldOffset(Offset = "0x44")]
	public BE_SlotSpot SpotInArray;

	[Token(Token = "0x4006439")]
	[FieldOffset(Offset = "0x48")]
	public int DefaultHeight;

	[Token(Token = "0x400643A")]
	[FieldOffset(Offset = "0x4C")]
	public int DefaultWidth;

	[Token(Token = "0x400643B")]
	[FieldOffset(Offset = "0x50")]
	public int LeftRightgap;

	[Token(Token = "0x400643C")]
	[FieldOffset(Offset = "0x54")]
	public int UpDownMarginSize;

	[Token(Token = "0x400643D")]
	[FieldOffset(Offset = "0x58")]
	public int XStartPos;

	[Token(Token = "0x400643E")]
	[FieldOffset(Offset = "0x5C")]
	public LocalVarDefineData LocalVarDefData;

	[Token(Token = "0x400643F")]
	[FieldOffset(Offset = "0x60")]
	public BE_BlockSectionHeader_Label SlotLabel;

	[Token(Token = "0x170007CE")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0x2D225A8", Offset = "0x2D225A8", VA = "0x2D225A8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CF")]
	public Vector2 AEOEMDPAGHB
	{
		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x2D2260C", Offset = "0x2D2260C", VA = "0x2D2260C", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x170007D0")]
	public UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x2D226A0", Offset = "0x2D226A0", VA = "0x2D226A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D1")]
	public TypeInfo BCFPKGPHCJM
	{
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x2D2279C", Offset = "0x2D2279C", VA = "0x2D2279C")]
		get
		{
			return default(TypeInfo);
		}
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x2D22808", Offset = "0x2D22808", VA = "0x2D22808")]
		set
		{
		}
	}

	[Token(Token = "0x170007D2")]
	public EKEOCIDDIFH KGPENJELKCL
	{
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x2D22888", Offset = "0x2D22888", VA = "0x2D22888")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x2D228E0", Offset = "0x2D228E0", VA = "0x2D228E0")]
		set
		{
		}
	}

	[Token(Token = "0x170007D3")]
	public EKEOCIDDIFH DCNMEONMGKN
	{
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x2D22940", Offset = "0x2D22940", VA = "0x2D22940", Slot = "10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x2D22998", Offset = "0x2D22998", VA = "0x2D22998", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x170007D4")]
	public KMMOEDDCDFM PBDCADHIAJM
	{
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x2D229F8", Offset = "0x2D229F8", VA = "0x2D229F8", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x2D22A50", Offset = "0x2D22A50", VA = "0x2D22A50", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x170007D5")]
	public ValueData KBNABDKBGPE
	{
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x2D22AB0", Offset = "0x2D22AB0", VA = "0x2D22AB0", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x2D22B08", Offset = "0x2D22B08", VA = "0x2D22B08", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x6005C3C")]
	[Address(RVA = "0x2D22578", Offset = "0x2D22578", VA = "0x2D22578")]
	public BE_BlockSectionHeader_Slot()
	{
	}

	[Token(Token = "0x6005C4A")]
	[Address(RVA = "0x2D22B68", Offset = "0x2D22B68", VA = "0x2D22B68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005C4B")]
	[Address(RVA = "0x2D22C70", Offset = "0x2D22C70", VA = "0x2D22C70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005C4C")]
	[Address(RVA = "0x2D22EF0", Offset = "0x2D22EF0", VA = "0x2D22EF0")]
	public void InitSlot(TypeInfo OPJKJHBKLGN)
	{
	}

	[Token(Token = "0x6005C4D")]
	[Address(RVA = "0x2D22FBC", Offset = "0x2D22FBC", VA = "0x2D22FBC", Slot = "7")]
	public void UpdateWidgetDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD = true)
	{
	}

	[Token(Token = "0x6005C4E")]
	[Address(RVA = "0x2D2326C", Offset = "0x2D2326C", VA = "0x2D2326C")]
	public void UpdateSlotSize()
	{
	}

	[Token(Token = "0x6005C4F")]
	[Address(RVA = "0x2D237D0", Offset = "0x2D237D0", VA = "0x2D237D0", Slot = "14")]
	public void SetValue(string IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x6005C50")]
	[Address(RVA = "0x2D22BCC", Offset = "0x2D22BCC", VA = "0x2D22BCC")]
	public void SetHighLightSprite(bool GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6005C51")]
	[Address(RVA = "0x2D2382C", Offset = "0x2D2382C", VA = "0x2D2382C")]
	public void SetBindLocalVarDefData(LocalVarDefineData OEJAAFHJDIF)
	{
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C09")]
public class BE_BlockSectionHeader_DropdownList : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2000C0A")]
	private sealed class AIGLFIIBAOP
	{
		[Token(Token = "0x40063DA")]
		[FieldOffset(Offset = "0x8")]
		internal BE_DropdownItem CMNLNABNDOM;

		[Token(Token = "0x40063DB")]
		[FieldOffset(Offset = "0xC")]
		internal BE_BlockSectionHeader_DropdownList GADHAMJEKIM;

		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x160ECFC", Offset = "0x160ECFC", VA = "0x160ECFC")]
		public AIGLFIIBAOP()
		{
		}

		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x1611220", Offset = "0x1611220", VA = "0x1611220")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x40063BE")]
	[FieldOffset(Offset = "0xC")]
	public UIButton Btn;

	[Token(Token = "0x40063BF")]
	[FieldOffset(Offset = "0x10")]
	public GameObject DropDownPanel;

	[Token(Token = "0x40063C0")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CurrentLabel;

	[Token(Token = "0x40063C1")]
	[FieldOffset(Offset = "0x18")]
	public BE_DropdownItem EnumItem;

	[Token(Token = "0x40063C2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite CurrentOptBG;

	[Token(Token = "0x40063C3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite FieldTypeHL;

	[Token(Token = "0x40063C4")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SVBG;

	[Token(Token = "0x40063C5")]
	[FieldOffset(Offset = "0x28")]
	public UIPanel SVPanel;

	[Token(Token = "0x40063C6")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel SVBarPanel;

	[Token(Token = "0x40063C7")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView SV;

	[Token(Token = "0x40063C8")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollBar SVBar;

	[Token(Token = "0x40063C9")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40063CA")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Arrow;

	[Token(Token = "0x40063CB")]
	[FieldOffset(Offset = "0x40")]
	private int DONCPHLAOHK;

	[Token(Token = "0x40063CC")]
	[FieldOffset(Offset = "0x44")]
	private bool ELKLOINGBKF;

	[Token(Token = "0x40063CD")]
	[FieldOffset(Offset = "0x48")]
	private BEEnumData JGOKJBCIAMA;

	[Token(Token = "0x40063CE")]
	[FieldOffset(Offset = "0x4C")]
	private List<BE_DropdownItem> JJAJADEBHPC;

	[Token(Token = "0x40063CF")]
	[FieldOffset(Offset = "0x50")]
	private List<BEEnumData> DLBKINFIFMM;

	[Token(Token = "0x40063D0")]
	[FieldOffset(Offset = "0x54")]
	private UIPanel GLONBJKAPBI;

	[Token(Token = "0x40063D1")]
	[FieldOffset(Offset = "0x58")]
	private UIClickMask LPKCCABHLFF;

	[Token(Token = "0x40063D2")]
	[FieldOffset(Offset = "0x5C")]
	private EKEOCIDDIFH MFKJLEFDICK;

	[Token(Token = "0x40063D3")]
	[FieldOffset(Offset = "0x60")]
	private KMMOEDDCDFM IKDFPILOJPC;

	[Token(Token = "0x40063D4")]
	[FieldOffset(Offset = "0x64")]
	private UIWidget GKGOLADJHDC;

	[Token(Token = "0x40063D5")]
	[FieldOffset(Offset = "0x68")]
	private ValueData OOFCHNNKOFD;

	[Token(Token = "0x40063D6")]
	[FieldOffset(Offset = "0x6C")]
	private JJIEJICBBPG AJGPIDGGJAB;

	[Token(Token = "0x40063D7")]
	[FieldOffset(Offset = "0x70")]
	public int OffSetX;

	[Token(Token = "0x40063D8")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ValueData> HMDOHFBHDOB;

	[Token(Token = "0x40063D9")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ValueData> AOCDJNOINOH;

	[Token(Token = "0x17000798")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x160DA4C", Offset = "0x160DA4C", VA = "0x160DA4C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000799")]
	public EKEOCIDDIFH DCNMEONMGKN
	{
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x160DAB0", Offset = "0x160DAB0", VA = "0x160DAB0", Slot = "10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x160DB08", Offset = "0x160DB08", VA = "0x160DB08", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x1700079A")]
	public KMMOEDDCDFM PBDCADHIAJM
	{
		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0x160DB68", Offset = "0x160DB68", VA = "0x160DB68", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0x160DBC0", Offset = "0x160DBC0", VA = "0x160DBC0", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700079B")]
	public Vector2 AEOEMDPAGHB
	{
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x160DC20", Offset = "0x160DC20", VA = "0x160DC20", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700079C")]
	public UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0x160DCB4", Offset = "0x160DCB4", VA = "0x160DCB4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700079D")]
	public ValueData KBNABDKBGPE
	{
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x160DD0C", Offset = "0x160DD0C", VA = "0x160DD0C", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x160DD64", Offset = "0x160DD64", VA = "0x160DD64", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x6005B88")]
	[Address(RVA = "0x160D984", Offset = "0x160D984", VA = "0x160D984")]
	public BE_BlockSectionHeader_DropdownList()
	{
	}

	[Token(Token = "0x6005B92")]
	[Address(RVA = "0x160DDC4", Offset = "0x160DDC4", VA = "0x160DDC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B93")]
	[Address(RVA = "0x160E0F8", Offset = "0x160E0F8", VA = "0x160E0F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6005B94")]
	[Address(RVA = "0x160E3F0", Offset = "0x160E3F0", VA = "0x160E3F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005B95")]
	[Address(RVA = "0x160E464", Offset = "0x160E464", VA = "0x160E464")]
	public void Init(List<BEEnumData> EMDIIJILGGE, int GBKDFDABOEN)
	{
	}

	[Token(Token = "0x6005B96")]
	[Address(RVA = "0x160F100", Offset = "0x160F100", VA = "0x160F100")]
	private void EHNIIJLHABL()
	{
	}

	[Token(Token = "0x6005B97")]
	[Address(RVA = "0x160F320", Offset = "0x160F320", VA = "0x160F320")]
	private void ABEFLKPLCJI(string NKPMJGKMIGJ, int IBBCEKAHMID)
	{
	}

	[Token(Token = "0x6005B98")]
	[Address(RVA = "0x160F8C4", Offset = "0x160F8C4", VA = "0x160F8C4")]
	private void FNFKHCPMDBM()
	{
	}

	[Token(Token = "0x6005B99")]
	[Address(RVA = "0x160FB0C", Offset = "0x160FB0C", VA = "0x160FB0C")]
	private void NALANHECGHD()
	{
	}

	[Token(Token = "0x6005B9A")]
	[Address(RVA = "0x160FEC8", Offset = "0x160FEC8", VA = "0x160FEC8")]
	private void JNLJPOCCPHK()
	{
	}

	[Token(Token = "0x6005B9B")]
	[Address(RVA = "0x1610B44", Offset = "0x1610B44", VA = "0x1610B44")]
	public BEEnumData GetEnumData()
	{
		return null;
	}

	[Token(Token = "0x6005B9C")]
	[Address(RVA = "0x160F500", Offset = "0x160F500", VA = "0x160F500")]
	private void IGHMFJKDBGM(BEEnumData LJEJKLDPKIJ)
	{
	}

	[Token(Token = "0x6005B9D")]
	[Address(RVA = "0x1610B9C", Offset = "0x1610B9C", VA = "0x1610B9C")]
	public void CmdSetEnum(BEEnumData LJEJKLDPKIJ)
	{
	}

	[Token(Token = "0x6005B9E")]
	[Address(RVA = "0x160FBCC", Offset = "0x160FBCC", VA = "0x160FBCC")]
	private void OLLIFFLMGGE()
	{
	}

	[Token(Token = "0x6005B9F")]
	[Address(RVA = "0x1610D94", Offset = "0x1610D94", VA = "0x1610D94", Slot = "14")]
	public void SetValue(string IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x6005BA0")]
	[Address(RVA = "0x1610DF0", Offset = "0x1610DF0", VA = "0x1610DF0", Slot = "7")]
	public void UpdateWidgetDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD = true)
	{
	}

	[Token(Token = "0x6005BA1")]
	[Address(RVA = "0x160ED04", Offset = "0x160ED04", VA = "0x160ED04")]
	private void BHOHFCCCNHD()
	{
	}

	[Token(Token = "0x6005BA2")]
	[Address(RVA = "0x16110E0", Offset = "0x16110E0", VA = "0x16110E0")]
	private static bool FPMMGEAINBG(ValueData HGMBMICDALC)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BA3")]
	[Address(RVA = "0x1611180", Offset = "0x1611180", VA = "0x1611180")]
	private static bool LNJPNNBJCHK(ValueData HGMBMICDALC)
	{
		return default(bool);
	}
}

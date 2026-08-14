using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003681")]
public class UIHudInventoryView : UIBaseView
{
	[Token(Token = "0x4015E63")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose1;

	[Token(Token = "0x4015E64")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4015E65")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollViewRoot;

	[Token(Token = "0x4015E66")]
	[FieldOffset(Offset = "0x20")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x4015E67")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemListGridTF;

	[Token(Token = "0x4015E68")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x4015E69")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BagCapacity;

	[Token(Token = "0x4015E6A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Bagrighttxt;

	[Token(Token = "0x4015E6B")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnSort;

	[Token(Token = "0x4015E6C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SortSpr;

	[Token(Token = "0x4015E6D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel EmptyTipLabel;

	[Token(Token = "0x4015E6E")]
	[FieldOffset(Offset = "0x40")]
	public Transform VestSlot;

	[Token(Token = "0x4015E6F")]
	[FieldOffset(Offset = "0x44")]
	public GameObject VestHolderEmptyBG;

	[Token(Token = "0x4015E70")]
	[FieldOffset(Offset = "0x48")]
	public UIToggle VestToggle;

	[Token(Token = "0x4015E71")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject VestHighlightGO;

	[Token(Token = "0x4015E72")]
	[FieldOffset(Offset = "0x50")]
	public Transform HelmetSlot;

	[Token(Token = "0x4015E73")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HelmetHolderEmptyBG;

	[Token(Token = "0x4015E74")]
	[FieldOffset(Offset = "0x58")]
	public UIToggle HelmetToggle;

	[Token(Token = "0x4015E75")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HelmetHighlightGO;

	[Token(Token = "0x4015E76")]
	[FieldOffset(Offset = "0x60")]
	public Transform BagSlot;

	[Token(Token = "0x4015E77")]
	[FieldOffset(Offset = "0x64")]
	public GameObject BagHolderEmptyBG;

	[Token(Token = "0x4015E78")]
	[FieldOffset(Offset = "0x68")]
	public UIToggle BagToggle;

	[Token(Token = "0x4015E79")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BagHighlightGO;

	[Token(Token = "0x4015E7A")]
	[FieldOffset(Offset = "0x70")]
	public Transform CamouflageSlot;

	[Token(Token = "0x4015E7B")]
	[FieldOffset(Offset = "0x74")]
	public GameObject CamouflageHolderEmptyBG;

	[Token(Token = "0x4015E7C")]
	[FieldOffset(Offset = "0x78")]
	public UIToggle CoverToggle;

	[Token(Token = "0x4015E7D")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject CoverHighlightGO;

	[Token(Token = "0x4015E7E")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DescItemName;

	[Token(Token = "0x4015E7F")]
	[FieldOffset(Offset = "0x84")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015E80")]
	[FieldOffset(Offset = "0x88")]
	public UITable Table;

	[Token(Token = "0x4015E81")]
	[FieldOffset(Offset = "0x8C")]
	public UITable TagTable;

	[Token(Token = "0x4015E82")]
	[FieldOffset(Offset = "0x90")]
	public UILabel DescItemInfo;

	[Token(Token = "0x4015E83")]
	[FieldOffset(Offset = "0x94")]
	public GameObject TagDescContainer;

	[Token(Token = "0x4015E84")]
	[FieldOffset(Offset = "0x98")]
	public UILabel TagDesc;

	[Token(Token = "0x4015E85")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite TagDescBG;

	[Token(Token = "0x4015E86")]
	[FieldOffset(Offset = "0xA0")]
	public Transform Prim1WeaponSlot;

	[Token(Token = "0x4015E87")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject P1HolderEmptyBG;

	[Token(Token = "0x4015E88")]
	[FieldOffset(Offset = "0xA8")]
	public UIToggle PrimaryWToggle;

	[Token(Token = "0x4015E89")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject PrimaryWHighlightGO;

	[Token(Token = "0x4015E8A")]
	[FieldOffset(Offset = "0xB0")]
	public Transform MeleeWeaponSlot;

	[Token(Token = "0x4015E8B")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject M1HolderEmptyBG;

	[Token(Token = "0x4015E8C")]
	[FieldOffset(Offset = "0xB8")]
	public UIToggle MeleeToggle;

	[Token(Token = "0x4015E8D")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject MeleeHighlightGO;

	[Token(Token = "0x4015E8E")]
	[FieldOffset(Offset = "0xC0")]
	public Transform Prim2WeaponSlot;

	[Token(Token = "0x4015E8F")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject P2HolderEmptyBG;

	[Token(Token = "0x4015E90")]
	[FieldOffset(Offset = "0xC8")]
	public UIToggle SecondaryWToggle;

	[Token(Token = "0x4015E91")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject SecondaryWHighlightGO;

	[Token(Token = "0x4015E92")]
	[FieldOffset(Offset = "0xD0")]
	public Transform SecWeaponSlot;

	[Token(Token = "0x4015E93")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject S1HolderEmptyBG;

	[Token(Token = "0x4015E94")]
	[FieldOffset(Offset = "0xD8")]
	public UIToggle SideWToggle;

	[Token(Token = "0x4015E95")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject SideWHighlightGO;

	[Token(Token = "0x4015E96")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject Token;

	[Token(Token = "0x4015E97")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite TokenIcon;

	[Token(Token = "0x4015E98")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel TokenNum;

	[Token(Token = "0x4015E99")]
	[FieldOffset(Offset = "0xEC")]
	public Transform PartialTransform;

	[Token(Token = "0x4015E9A")]
	[FieldOffset(Offset = "0xF0")]
	public UIPanel TrashPanel;

	[Token(Token = "0x4015E9B")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject TrashGO;

	[Token(Token = "0x4015E9C")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject TrashDragHighlight;

	[Token(Token = "0x4015E9D")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject TrashDragOverHighlight;

	[Token(Token = "0x4015E9E")]
	[FieldOffset(Offset = "0x100")]
	public GameObject TrashPartialGO;

	[Token(Token = "0x4015E9F")]
	[FieldOffset(Offset = "0x104")]
	public GameObject TrashPartialDragHighlight;

	[Token(Token = "0x4015EA0")]
	[FieldOffset(Offset = "0x108")]
	public GameObject TrashPartialDragOverHighlight;

	[Token(Token = "0x4015EA1")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject TrashHint;

	[Token(Token = "0x4015EA2")]
	[FieldOffset(Offset = "0x110")]
	public UIButton BtnCloseMask;

	[Token(Token = "0x6016730")]
	[Address(RVA = "0x209EF04", Offset = "0x209EF04", VA = "0x209EF04")]
	public UIHudInventoryView()
	{
	}

	[Token(Token = "0x6016731")]
	[Address(RVA = "0x209EF0C", Offset = "0x209EF0C", VA = "0x209EF0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016732")]
	[Address(RVA = "0x20A0598", Offset = "0x20A0598", VA = "0x20A0598")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}

using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C01")]
public class BE_ProgrammingEnv : UIDragDropContainer, _Attribute
{
	[Token(Token = "0x400637D")]
	[FieldOffset(Offset = "0x10")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x400637E")]
	[FieldOffset(Offset = "0x14")]
	private UIRoot OALGMJPFGGL;

	[Token(Token = "0x400637F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ProgrammingEnv;

	[Token(Token = "0x4006380")]
	[FieldOffset(Offset = "0x1C")]
	public UIColor TrashEnv;

	[Token(Token = "0x4006381")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget NJDFCIOLDJC;

	[Token(Token = "0x4006382")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TrashSprite;

	[Token(Token = "0x4006383")]
	[FieldOffset(Offset = "0x28")]
	public Transform ScaleRoot;

	[Token(Token = "0x4006384")]
	[FieldOffset(Offset = "0x2C")]
	public Transform MoveRoot;

	[Token(Token = "0x4006385")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 MEBIDPPEFHF;

	[Token(Token = "0x4006386")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 GFFCCBNNAAO;

	[Token(Token = "0x4006387")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 FLPKAIJMEMJ;

	[Token(Token = "0x4006388")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] MPENKDNHGPA;

	[Token(Token = "0x4006389")]
	[FieldOffset(Offset = "0x4C")]
	private float OMKBMFBKCMN;

	[Token(Token = "0x400638A")]
	[FieldOffset(Offset = "0x50")]
	private bool IMOGCLHBBPL;

	[Token(Token = "0x400638B")]
	[FieldOffset(Offset = "0x54")]
	private List<EJPDJDBMLIN> _003CNLIECKIADKD_003Ek__BackingField;

	[Token(Token = "0x400638C")]
	[FieldOffset(Offset = "0x58")]
	private GraphData ANECPHJJNCO;

	[Token(Token = "0x400638D")]
	[FieldOffset(Offset = "0x5C")]
	private BODKAJJDEEL CNKMDADFDNI;

	[Token(Token = "0x400638E")]
	[FieldOffset(Offset = "0x60")]
	private EHEELGMKJHD GKHKCDFJAEJ;

	[Token(Token = "0x1700077C")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0x2D469EC", Offset = "0x2D469EC", VA = "0x2D469EC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077D")]
	public List<EJPDJDBMLIN> ODCNPJPHBCA
	{
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0x2D46AD4", Offset = "0x2D46AD4", VA = "0x2D46AD4", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B02")]
		[Address(RVA = "0x2D46ADC", Offset = "0x2D46ADC", VA = "0x2D46ADC")]
		set
		{
		}
	}

	[Token(Token = "0x6005AFF")]
	[Address(RVA = "0x2D469E4", Offset = "0x2D469E4", VA = "0x2D469E4")]
	public BE_ProgrammingEnv()
	{
	}

	[Token(Token = "0x6005B03")]
	[Address(RVA = "0x2D46AE4", Offset = "0x2D46AE4", VA = "0x2D46AE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B04")]
	[Address(RVA = "0x2D4708C", Offset = "0x2D4708C", VA = "0x2D4708C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005B05")]
	[Address(RVA = "0x2D47458", Offset = "0x2D47458", VA = "0x2D47458")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005B06")]
	[Address(RVA = "0x2D47824", Offset = "0x2D47824", VA = "0x2D47824")]
	private void Update()
	{
	}

	[Token(Token = "0x6005B07")]
	[Address(RVA = "0x2D47950", Offset = "0x2D47950", VA = "0x2D47950")]
	private void OMCCCCIPJNO(GameObject OMDFNKNJDII, bool GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6005B08")]
	[Address(RVA = "0x2D47CAC", Offset = "0x2D47CAC", VA = "0x2D47CAC")]
	private void NJEKHAOIJIK(List<LeanFinger> EHMDKAPDFFP)
	{
	}

	[Token(Token = "0x6005B09")]
	[Address(RVA = "0x2D481D0", Offset = "0x2D481D0", VA = "0x2D481D0")]
	private void BJCJMIJEDGL(GameObject OMDFNKNJDII, Vector2 LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6005B0A")]
	[Address(RVA = "0x2D46C00", Offset = "0x2D46C00", VA = "0x2D46C00", Slot = "7")]
	public void UpdateBlocksList()
	{
	}

	[Token(Token = "0x6005B0B")]
	[Address(RVA = "0x2D48768", Offset = "0x2D48768", VA = "0x2D48768", Slot = "8")]
	public void ClearBlocks()
	{
	}

	[Token(Token = "0x6005B0C")]
	[Address(RVA = "0x2D2DF38", Offset = "0x2D2DF38", VA = "0x2D2DF38")]
	public UIWidget GetTrashWidget()
	{
		return null;
	}

	[Token(Token = "0x6005B0D")]
	[Address(RVA = "0x2D2AB6C", Offset = "0x2D2AB6C", VA = "0x2D2AB6C")]
	public void UpdateTrashColor()
	{
	}

	[Token(Token = "0x6005B0E")]
	[Address(RVA = "0x2D3654C", Offset = "0x2D3654C", VA = "0x2D3654C")]
	public void SetTrashDefaultColor()
	{
	}

	[Token(Token = "0x6005B0F")]
	[Address(RVA = "0x2D48094", Offset = "0x2D48094", VA = "0x2D48094")]
	public bool CanInteractive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B10")]
	[Address(RVA = "0x2D43760", Offset = "0x2D43760", VA = "0x2D43760")]
	public void Reset()
	{
	}
}

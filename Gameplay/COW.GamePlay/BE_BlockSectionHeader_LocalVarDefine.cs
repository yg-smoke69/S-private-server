using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C11")]
public class BE_BlockSectionHeader_LocalVarDefine : MonoBehaviour, _Attribute
{
	[Token(Token = "0x400640B")]
	[FieldOffset(Offset = "0xC")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x400640C")]
	[FieldOffset(Offset = "0x10")]
	private UIWidget GKGOLADJHDC;

	[Token(Token = "0x400640D")]
	[FieldOffset(Offset = "0x14")]
	private EKEOCIDDIFH MFKJLEFDICK;

	[Token(Token = "0x400640E")]
	[FieldOffset(Offset = "0x18")]
	private KMMOEDDCDFM IKDFPILOJPC;

	[Token(Token = "0x400640F")]
	[FieldOffset(Offset = "0x1C")]
	public LocalVarDefineData LocalVarDefData;

	[Token(Token = "0x4006410")]
	[FieldOffset(Offset = "0x20")]
	public UIInput m_Input;

	[Token(Token = "0x4006411")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InputContainer;

	[Token(Token = "0x4006412")]
	[FieldOffset(Offset = "0x28")]
	public List<UISprite> BGList;

	[Token(Token = "0x4006413")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DefaultLabel;

	[Token(Token = "0x4006414")]
	[FieldOffset(Offset = "0x30")]
	public BE_LocalVarDragDropItem DragItem;

	[Token(Token = "0x4006415")]
	[FieldOffset(Offset = "0x34")]
	public UISprite HighLightSprite;

	[Token(Token = "0x4006416")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpotSprite;

	[Token(Token = "0x4006417")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget InputWidget;

	[Token(Token = "0x4006418")]
	[FieldOffset(Offset = "0x40")]
	private UIClickMask NDCABADGHMP;

	[Token(Token = "0x4006419")]
	[FieldOffset(Offset = "0x44")]
	private string OGGCGPKPGAD;

	[Token(Token = "0x400641A")]
	[FieldOffset(Offset = "0x48")]
	private CPOKEBGBFBG ODHECFOJMIO;

	[Token(Token = "0x400641B")]
	[FieldOffset(Offset = "0x4C")]
	public int LeftRightMarginSize;

	[Token(Token = "0x170007C2")]
	private Vector2 DFMMEBPPEHK
	{
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x161DBC4", Offset = "0x161DBC4", VA = "0x161DBC4", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x170007C3")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x161DB6C", Offset = "0x161DB6C", VA = "0x161DB6C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C4")]
	public UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x161DC58", Offset = "0x161DC58", VA = "0x161DC58", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C5")]
	public EKEOCIDDIFH DCNMEONMGKN
	{
		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x161DCB0", Offset = "0x161DCB0", VA = "0x161DCB0", Slot = "10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x161DD08", Offset = "0x161DD08", VA = "0x161DD08", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x170007C6")]
	public KMMOEDDCDFM PBDCADHIAJM
	{
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x161DD68", Offset = "0x161DD68", VA = "0x161DD68", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x161A0B8", Offset = "0x161A0B8", VA = "0x161A0B8", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x170007C7")]
	public ValueData KBNABDKBGPE
	{
		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x161DDC0", Offset = "0x161DDC0", VA = "0x161DDC0", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x161DE18", Offset = "0x161DE18", VA = "0x161DE18", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x6005C0E")]
	[Address(RVA = "0x161DAC4", Offset = "0x161DAC4", VA = "0x161DAC4")]
	public BE_BlockSectionHeader_LocalVarDefine()
	{
	}

	[Token(Token = "0x6005C18")]
	[Address(RVA = "0x161DE74", Offset = "0x161DE74", VA = "0x161DE74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005C19")]
	[Address(RVA = "0x161E02C", Offset = "0x161E02C", VA = "0x161E02C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005C1A")]
	[Address(RVA = "0x161E0A0", Offset = "0x161E0A0", VA = "0x161E0A0")]
	public void VarNameChange()
	{
	}

	[Token(Token = "0x6005C1B")]
	[Address(RVA = "0x1619E24", Offset = "0x1619E24", VA = "0x1619E24")]
	public void InitLocalVarDefData(LocalVarDefineData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005C1C")]
	[Address(RVA = "0x161E3F0", Offset = "0x161E3F0", VA = "0x161E3F0")]
	private void CGGPNMANPML()
	{
	}

	[Token(Token = "0x6005C1D")]
	[Address(RVA = "0x161E1BC", Offset = "0x161E1BC", VA = "0x161E1BC")]
	private void HJGJJNPIHOL()
	{
	}

	[Token(Token = "0x6005C1E")]
	[Address(RVA = "0x161E818", Offset = "0x161E818", VA = "0x161E818")]
	private void BDKHINHLIAE()
	{
	}

	[Token(Token = "0x6005C1F")]
	[Address(RVA = "0x161E8D0", Offset = "0x161E8D0", VA = "0x161E8D0", Slot = "7")]
	public void UpdateWidgetDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD)
	{
	}

	[Token(Token = "0x6005C20")]
	[Address(RVA = "0x161ECFC", Offset = "0x161ECFC", VA = "0x161ECFC", Slot = "14")]
	public void SetValue(string IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x6005C21")]
	[Address(RVA = "0x161ED58", Offset = "0x161ED58", VA = "0x161ED58")]
	public void SetDragItemCollider(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6005C22")]
	[Address(RVA = "0x161DF64", Offset = "0x161DF64", VA = "0x161DF64")]
	public void SetHighLightState(bool GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6005C23")]
	[Address(RVA = "0x161EE60", Offset = "0x161EE60", VA = "0x161EE60")]
	public void InputContainerClick()
	{
	}

	[Token(Token = "0x6005C24")]
	[Address(RVA = "0x161F034", Offset = "0x161F034", VA = "0x161F034")]
	private void GOEOONDNMNH()
	{
	}

	[Token(Token = "0x6005C25")]
	[Address(RVA = "0x161F28C", Offset = "0x161F28C", VA = "0x161F28C")]
	private void JBPNDPAIDNK()
	{
	}
}

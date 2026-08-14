using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D15")]
public class UIHudMedkitItem : MonoBehaviour
{
	[Token(Token = "0x401133A")]
	[FieldOffset(Offset = "0xC")]
	public UISprite ItemNormalBG;

	[Token(Token = "0x401133B")]
	[FieldOffset(Offset = "0x10")]
	public UISprite ItemSelectBG;

	[Token(Token = "0x401133C")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemTxtBG;

	[Token(Token = "0x401133D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ItemTxt;

	[Token(Token = "0x401133E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ItemDisable;

	[Token(Token = "0x401133F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ItemBG1;

	[Token(Token = "0x4011340")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ItemBG2;

	[Token(Token = "0x4011341")]
	[FieldOffset(Offset = "0x28")]
	public float StartAngle1;

	[Token(Token = "0x4011342")]
	[FieldOffset(Offset = "0x2C")]
	public float EndAngle1;

	[Token(Token = "0x4011343")]
	[FieldOffset(Offset = "0x30")]
	public float StartAngle2;

	[Token(Token = "0x4011344")]
	[FieldOffset(Offset = "0x34")]
	public float EndAngle2;

	[Token(Token = "0x4011345")]
	[FieldOffset(Offset = "0x38")]
	private Color m_SelectedColor;

	[Token(Token = "0x4011346")]
	[FieldOffset(Offset = "0x48")]
	private Color m_EmptyColor;

	[Token(Token = "0x4011347")]
	[FieldOffset(Offset = "0x58")]
	private CureGearSettingData m_ConfigData;

	[Token(Token = "0x4011348")]
	[FieldOffset(Offset = "0x5C")]
	private MedkitRouletteEnum m_CurState;

	[Token(Token = "0x4011349")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsSelect;

	[Token(Token = "0x401134A")]
	[FieldOffset(Offset = "0x64")]
	private int m_CurCount;

	[Token(Token = "0x6012D93")]
	[Address(RVA = "0x19C40E0", Offset = "0x19C40E0", VA = "0x19C40E0")]
	public UIHudMedkitItem()
	{
	}

	[Token(Token = "0x6012D94")]
	[Address(RVA = "0x19C40F0", Offset = "0x19C40F0", VA = "0x19C40F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012D95")]
	[Address(RVA = "0x19C458C", Offset = "0x19C458C", VA = "0x19C458C")]
	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	[Token(Token = "0x6012D96")]
	[Address(RVA = "0x19C4650", Offset = "0x19C4650", VA = "0x19C4650")]
	public void SetConfigData(CureGearSettingData configData)
	{
	}

	[Token(Token = "0x6012D97")]
	[Address(RVA = "0x19C4824", Offset = "0x19C4824", VA = "0x19C4824")]
	public void RefreshItemState()
	{
	}

	[Token(Token = "0x6012D98")]
	[Address(RVA = "0x19C41C8", Offset = "0x19C41C8", VA = "0x19C41C8")]
	public void SetState(MedkitRouletteEnum state)
	{
	}

	[Token(Token = "0x6012D99")]
	[Address(RVA = "0x19C49FC", Offset = "0x19C49FC", VA = "0x19C49FC")]
	public void SetSelectState(bool isSelect)
	{
	}

	[Token(Token = "0x6012D9A")]
	[Address(RVA = "0x19C4C94", Offset = "0x19C4C94", VA = "0x19C4C94")]
	public void SendMedkitRequest()
	{
	}

	[Token(Token = "0x6012D9B")]
	[Address(RVA = "0x19C5248", Offset = "0x19C5248", VA = "0x19C5248")]
	public void Update()
	{
	}
}

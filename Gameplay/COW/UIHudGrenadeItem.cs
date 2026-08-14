using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D13")]
public class UIHudGrenadeItem : MonoBehaviour
{
	[Token(Token = "0x4011325")]
	[FieldOffset(Offset = "0xC")]
	public UISprite ItemNormalBG;

	[Token(Token = "0x4011326")]
	[FieldOffset(Offset = "0x10")]
	public UISprite ItemSelectBG;

	[Token(Token = "0x4011327")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemTxtBG;

	[Token(Token = "0x4011328")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ItemTxt;

	[Token(Token = "0x4011329")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ItemDisable;

	[Token(Token = "0x401132A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ItemBG;

	[Token(Token = "0x401132B")]
	[FieldOffset(Offset = "0x24")]
	public float StartAngle1;

	[Token(Token = "0x401132C")]
	[FieldOffset(Offset = "0x28")]
	public float EndAngle1;

	[Token(Token = "0x401132D")]
	[FieldOffset(Offset = "0x2C")]
	public float StartAngle2;

	[Token(Token = "0x401132E")]
	[FieldOffset(Offset = "0x30")]
	public float EndAngle2;

	[Token(Token = "0x401132F")]
	[FieldOffset(Offset = "0x34")]
	private Color m_SelectedColor;

	[Token(Token = "0x4011330")]
	[FieldOffset(Offset = "0x44")]
	private Color m_EmptyColor;

	[Token(Token = "0x4011331")]
	[FieldOffset(Offset = "0x54")]
	private GrenadeTypeSettingData m_ConfigData;

	[Token(Token = "0x4011332")]
	[FieldOffset(Offset = "0x58")]
	private MedkitRouletteEnum m_CurState;

	[Token(Token = "0x4011333")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsSelect;

	[Token(Token = "0x4011334")]
	[FieldOffset(Offset = "0x60")]
	private int m_CurCount;

	[Token(Token = "0x6012D8B")]
	[Address(RVA = "0x13393C8", Offset = "0x13393C8", VA = "0x13393C8")]
	public UIHudGrenadeItem()
	{
	}

	[Token(Token = "0x6012D8C")]
	[Address(RVA = "0x13393D8", Offset = "0x13393D8", VA = "0x13393D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012D8D")]
	[Address(RVA = "0x1339874", Offset = "0x1339874", VA = "0x1339874")]
	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	[Token(Token = "0x6012D8E")]
	[Address(RVA = "0x1339938", Offset = "0x1339938", VA = "0x1339938")]
	public void SetConfigData(GrenadeTypeSettingData configData)
	{
	}

	[Token(Token = "0x6012D8F")]
	[Address(RVA = "0x1339B58", Offset = "0x1339B58", VA = "0x1339B58")]
	public void RefreshItemState()
	{
	}

	[Token(Token = "0x6012D90")]
	[Address(RVA = "0x13394B0", Offset = "0x13394B0", VA = "0x13394B0")]
	public void SetState(MedkitRouletteEnum state)
	{
	}

	[Token(Token = "0x6012D91")]
	[Address(RVA = "0x1339D30", Offset = "0x1339D30", VA = "0x1339D30")]
	public void SetSelectState(bool isSelect)
	{
	}

	[Token(Token = "0x6012D92")]
	[Address(RVA = "0x1339F68", Offset = "0x1339F68", VA = "0x1339F68")]
	public void SendGrenadeRequest()
	{
	}
}

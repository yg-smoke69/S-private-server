using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002AA7")]
public class UIProfileSettingPregameInfoDataItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x401064D")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileSettingPregameInfoDataItemView m_View;

	[Token(Token = "0x401064E")]
	[FieldOffset(Offset = "0x2C")]
	private EAccount.Choices m_DataType;

	[Token(Token = "0x401064F")]
	[FieldOffset(Offset = "0x30")]
	private UIModelProfile m_ModelProfile;

	[Token(Token = "0x6011726")]
	[Address(RVA = "0x1AB36D4", Offset = "0x1AB36D4", VA = "0x1AB36D4")]
	public UIProfileSettingPregameInfoDataItemController()
	{
	}

	[Token(Token = "0x6011727")]
	[Address(RVA = "0x1AB3758", Offset = "0x1AB3758", VA = "0x1AB3758")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011728")]
	[Address(RVA = "0x1AB3800", Offset = "0x1AB3800", VA = "0x1AB3800", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011729")]
	[Address(RVA = "0x1AB39E0", Offset = "0x1AB39E0", VA = "0x1AB39E0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601172A")]
	[Address(RVA = "0x1AB3BCC", Offset = "0x1AB3BCC", VA = "0x1AB3BCC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601172B")]
	[Address(RVA = "0x1AB3C60", Offset = "0x1AB3C60", VA = "0x1AB3C60")]
	public void SetViewData(EAccount.Choices eDataType)
	{
	}

	[Token(Token = "0x601172C")]
	[Address(RVA = "0x1AB4164", Offset = "0x1AB4164", VA = "0x1AB4164")]
	public void ShowGuide(Transform rootGuide, int depth)
	{
	}

	[Token(Token = "0x601172D")]
	[Address(RVA = "0x1AB3A98", Offset = "0x1AB3A98", VA = "0x1AB3A98")]
	private void RefreshSelectState()
	{
	}

	[Token(Token = "0x601172E")]
	[Address(RVA = "0x1AB4450", Offset = "0x1AB4450", VA = "0x1AB4450")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x601172F")]
	[Address(RVA = "0x1AB4500", Offset = "0x1AB4500", VA = "0x1AB4500")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

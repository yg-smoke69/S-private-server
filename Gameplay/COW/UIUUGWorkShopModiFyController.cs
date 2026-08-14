using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BCA")]
public class UIUUGWorkShopModiFyController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010BA1")]
	[FieldOffset(Offset = "0x48")]
	private UIUUGWorkShopModifyView m_View;

	[Token(Token = "0x4010BA2")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x4010BA3")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsSubscribed;

	[Token(Token = "0x4010BA4")]
	[FieldOffset(Offset = "0x54")]
	private uint m_SubscribeSlotId;

	[Token(Token = "0x4010BA5")]
	[FieldOffset(Offset = "0x58")]
	private SceneEditSlotInfo m_CurSlotInfo;

	[Token(Token = "0x4010BA6")]
	[FieldOffset(Offset = "0x5C")]
	private string m_Code;

	[Token(Token = "0x4010BA7")]
	[FieldOffset(Offset = "0x60")]
	private string m_DefaultSignature;

	[Token(Token = "0x4010BA8")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsFE;

	[Token(Token = "0x4010BA9")]
	[FieldOffset(Offset = "0x68")]
	private SwitchDesc m_NameSwitch;

	[Token(Token = "0x4010BAA")]
	[FieldOffset(Offset = "0x6C")]
	private SwitchDesc m_DescSwitch;

	[Token(Token = "0x4010BAB")]
	[FieldOffset(Offset = "0x70")]
	private List<UIWorkshopModeTagController> m_Tags;

	[Token(Token = "0x60121D6")]
	[Address(RVA = "0xF4589C", Offset = "0xF4589C", VA = "0xF4589C")]
	public UIUUGWorkShopModiFyController()
	{
	}

	[Token(Token = "0x60121D7")]
	[Address(RVA = "0xF458A4", Offset = "0xF458A4", VA = "0xF458A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60121D8")]
	[Address(RVA = "0xF4594C", Offset = "0xF4594C", VA = "0xF4594C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121D9")]
	[Address(RVA = "0xF46310", Offset = "0xF46310", VA = "0xF46310")]
	private void OnBtnModify()
	{
	}

	[Token(Token = "0x60121DA")]
	[Address(RVA = "0xF468AC", Offset = "0xF468AC", VA = "0xF468AC")]
	private void OnSignatureChange()
	{
	}

	[Token(Token = "0x60121DB")]
	[Address(RVA = "0xF46900", Offset = "0xF46900", VA = "0xF46900")]
	private void OnGetFocus()
	{
	}

	[Token(Token = "0x60121DC")]
	[Address(RVA = "0xF46AA4", Offset = "0xF46AA4", VA = "0xF46AA4")]
	private void OnLostFocus()
	{
	}

	[Token(Token = "0x60121DD")]
	[Address(RVA = "0xF47044", Offset = "0xF47044", VA = "0xF47044")]
	private void OnFixClick()
	{
	}

	[Token(Token = "0x60121DE")]
	[Address(RVA = "0xF47338", Offset = "0xF47338", VA = "0xF47338", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60121DF")]
	[Address(RVA = "0xF47404", Offset = "0xF47404", VA = "0xF47404")]
	public void SetUIDataBySceneEditSlotInfo(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x60121E0")]
	[Address(RVA = "0xF48FCC", Offset = "0xF48FCC", VA = "0xF48FCC")]
	private void OnCopyWorkshopCodeClick()
	{
	}

	[Token(Token = "0x60121E1")]
	[Address(RVA = "0xF493D4", Offset = "0xF493D4", VA = "0xF493D4")]
	private void OnShareClick()
	{
	}

	[Token(Token = "0x60121E2")]
	[Address(RVA = "0xF496DC", Offset = "0xF496DC", VA = "0xF496DC")]
	private void OnClickCreateBtn()
	{
	}

	[Token(Token = "0x60121E3")]
	[Address(RVA = "0xF49C54", Offset = "0xF49C54", VA = "0xF49C54")]
	private void OnAuthorNameClick()
	{
	}

	[Token(Token = "0x60121E4")]
	[Address(RVA = "0xF49F1C", Offset = "0xF49F1C", VA = "0xF49F1C")]
	private void OnBtnFullScreen()
	{
	}

	[Token(Token = "0x60121E5")]
	[Address(RVA = "0xF491AC", Offset = "0xF491AC", VA = "0xF491AC")]
	private void CopyToClipBoard(string code)
	{
	}

	[Token(Token = "0x60121E6")]
	[Address(RVA = "0xF4A154", Offset = "0xF4A154", VA = "0xF4A154")]
	private void OnHandleReturnToLobby()
	{
	}

	[Token(Token = "0x60121E7")]
	[Address(RVA = "0xF4A42C", Offset = "0xF4A42C", VA = "0xF4A42C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60121E8")]
	[Address(RVA = "0xF4A970", Offset = "0xF4A970", VA = "0xF4A970", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60121E9")]
	[Address(RVA = "0xF488A4", Offset = "0xF488A4", VA = "0xF488A4")]
	private void RefreshTags(uint[] tagsInfo, uint gameMode)
	{
	}

	[Token(Token = "0x60121EA")]
	[Address(RVA = "0xF4AA04", Offset = "0xF4AA04", VA = "0xF4AA04")]
	private void _003COnBtnModify_003Em__0(bool b)
	{
	}

	[Token(Token = "0x60121EB")]
	[Address(RVA = "0xF4AD34", Offset = "0xF4AD34", VA = "0xF4AD34")]
	private void _003COnBtnModify_003Em__1()
	{
	}

	[Token(Token = "0x60121EC")]
	[Address(RVA = "0xF4AE18", Offset = "0xF4AE18", VA = "0xF4AE18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60121ED")]
	[Address(RVA = "0xF4AE20", Offset = "0xF4AE20", VA = "0xF4AE20")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

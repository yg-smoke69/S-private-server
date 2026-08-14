using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B7E")]
public class UITrainingCampRecommendItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010A6A")]
	[FieldOffset(Offset = "0x38")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A6B")]
	[FieldOffset(Offset = "0x3C")]
	private UITrainingCampRecommendItemView m_View;

	[Token(Token = "0x4010A6C")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x4010A6D")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_AccountId;

	[Token(Token = "0x4010A6E")]
	[FieldOffset(Offset = "0x50")]
	private string m_Nickname;

	[Token(Token = "0x4010A6F")]
	[FieldOffset(Offset = "0x54")]
	private bool m_InSameRegion;

	[Token(Token = "0x6011F6F")]
	[Address(RVA = "0x1C1F8B0", Offset = "0x1C1F8B0", VA = "0x1C1F8B0")]
	public UITrainingCampRecommendItemController()
	{
	}

	[Token(Token = "0x6011F70")]
	[Address(RVA = "0x1C1F8B8", Offset = "0x1C1F8B8", VA = "0x1C1F8B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F71")]
	[Address(RVA = "0x1C1F95C", Offset = "0x1C1F95C", VA = "0x1C1F95C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F72")]
	[Address(RVA = "0x1C1FBD4", Offset = "0x1C1FBD4", VA = "0x1C1FBD4")]
	public void UpdateContent(bool isShow)
	{
	}

	[Token(Token = "0x6011F73")]
	[Address(RVA = "0x1C1FCE4", Offset = "0x1C1FCE4", VA = "0x1C1FCE4")]
	private void OnClickInVite()
	{
	}

	[Token(Token = "0x6011F74")]
	[Address(RVA = "0x1C203F0", Offset = "0x1C203F0", VA = "0x1C203F0")]
	private void OnClickInfo()
	{
	}

	[Token(Token = "0x6011F75")]
	[Address(RVA = "0x1C2053C", Offset = "0x1C2053C", VA = "0x1C2053C")]
	private void DisableInviteBtn()
	{
	}

	[Token(Token = "0x6011F76")]
	[Address(RVA = "0x1C20624", Offset = "0x1C20624", VA = "0x1C20624", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011F77")]
	[Address(RVA = "0x1C20784", Offset = "0x1C20784", VA = "0x1C20784")]
	public void SetData(BaseProfileInfo info)
	{
	}

	[Token(Token = "0x6011F78")]
	[Address(RVA = "0x1C20A64", Offset = "0x1C20A64", VA = "0x1C20A64", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011F79")]
	[Address(RVA = "0x1C20C00", Offset = "0x1C20C00", VA = "0x1C20C00", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011F7A")]
	[Address(RVA = "0x1C20C94", Offset = "0x1C20C94", VA = "0x1C20C94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

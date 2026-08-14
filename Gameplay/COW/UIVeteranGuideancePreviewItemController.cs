using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BDB")]
internal class UIVeteranGuideancePreviewItemController : UIBaseController
{
	[Token(Token = "0x4010BFC")]
	[FieldOffset(Offset = "0x28")]
	private EActivity.State m_State;

	[Token(Token = "0x4010BFD")]
	[FieldOffset(Offset = "0x2C")]
	private UIVeteranGuideancePreviewItemView m_View;

	[Token(Token = "0x4010BFE")]
	[FieldOffset(Offset = "0x30")]
	private UIModelVeteranSignin m_ModelVeteranSignin;

	[Token(Token = "0x4010BFF")]
	[FieldOffset(Offset = "0x34")]
	private int m_Slot;

	[Token(Token = "0x4010C00")]
	[FieldOffset(Offset = "0x38")]
	private OptionalBundleShowData m_Data;

	[Token(Token = "0x4010C01")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_RefreshBigPrizeDealayCallID;

	[Token(Token = "0x601228F")]
	[Address(RVA = "0x2856534", Offset = "0x2856534", VA = "0x2856534")]
	public UIVeteranGuideancePreviewItemController()
	{
	}

	[Token(Token = "0x6012290")]
	[Address(RVA = "0x28565B8", Offset = "0x28565B8", VA = "0x28565B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012291")]
	[Address(RVA = "0x285665C", Offset = "0x285665C", VA = "0x285665C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012292")]
	[Address(RVA = "0x28568C0", Offset = "0x28568C0", VA = "0x28568C0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012293")]
	[Address(RVA = "0x2856924", Offset = "0x2856924", VA = "0x2856924", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012294")]
	[Address(RVA = "0x2856A38", Offset = "0x2856A38", VA = "0x2856A38", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012295")]
	[Address(RVA = "0x2854104", Offset = "0x2854104", VA = "0x2854104")]
	public void SetViewData(OptionalBundleShowData data, int slot, bool isNotifyRefresh = false)
	{
	}

	[Token(Token = "0x6012296")]
	[Address(RVA = "0x2856B60", Offset = "0x2856B60", VA = "0x2856B60")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x6012297")]
	[Address(RVA = "0x2856A9C", Offset = "0x2856A9C", VA = "0x2856A9C")]
	public void RefreshBigPrize()
	{
	}

	[Token(Token = "0x6012298")]
	[Address(RVA = "0x28570B0", Offset = "0x28570B0", VA = "0x28570B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012299")]
	[Address(RVA = "0x28570B8", Offset = "0x28570B8", VA = "0x28570B8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601229A")]
	[Address(RVA = "0x28570C0", Offset = "0x28570C0", VA = "0x28570C0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601229B")]
	[Address(RVA = "0x28570C8", Offset = "0x28570C8", VA = "0x28570C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

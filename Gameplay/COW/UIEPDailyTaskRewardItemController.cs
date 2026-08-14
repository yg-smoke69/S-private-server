using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020D1")]
public class UIEPDailyTaskRewardItemController : UIBaseController
{
	[Token(Token = "0x400CD70")]
	[FieldOffset(Offset = "0x28")]
	private UIEPDailyTaskRewardItemView m_View;

	[Token(Token = "0x400CD71")]
	[FieldOffset(Offset = "0x2C")]
	private EPDailyRewardInfo m_Data;

	[Token(Token = "0x400CD72")]
	[FieldOffset(Offset = "0x30")]
	private float animTime;

	[Token(Token = "0x600A9C2")]
	[Address(RVA = "0x2BA812C", Offset = "0x2BA812C", VA = "0x2BA812C")]
	public UIEPDailyTaskRewardItemController()
	{
	}

	[Token(Token = "0x600A9C3")]
	[Address(RVA = "0x2BA81B0", Offset = "0x2BA81B0", VA = "0x2BA81B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9C4")]
	[Address(RVA = "0x2BA8470", Offset = "0x2BA8470", VA = "0x2BA8470", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A9C5")]
	[Address(RVA = "0x2BA860C", Offset = "0x2BA860C", VA = "0x2BA860C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9C6")]
	[Address(RVA = "0x2BA5FA8", Offset = "0x2BA5FA8", VA = "0x2BA5FA8")]
	public void SetData(EPDailyRewardInfo info)
	{
	}

	[Token(Token = "0x600A9C7")]
	[Address(RVA = "0x2BA8A68", Offset = "0x2BA8A68", VA = "0x2BA8A68")]
	public void OnEPDailyProcessAnimDone(object[] data)
	{
	}

	[Token(Token = "0x600A9C8")]
	[Address(RVA = "0x2BA8D5C", Offset = "0x2BA8D5C", VA = "0x2BA8D5C")]
	private void OnEPDailyRewardClaim(object[] data)
	{
	}

	[Token(Token = "0x600A9C9")]
	[Address(RVA = "0x2BA8F0C", Offset = "0x2BA8F0C", VA = "0x2BA8F0C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600A9CA")]
	[Address(RVA = "0x2BA86B0", Offset = "0x2BA86B0", VA = "0x2BA86B0")]
	private void SetButtonState()
	{
	}

	[Token(Token = "0x600A9CB")]
	[Address(RVA = "0x2BA907C", Offset = "0x2BA907C", VA = "0x2BA907C")]
	private void _003COnEPDailyProcessAnimDone_003Em__0()
	{
	}

	[Token(Token = "0x600A9CC")]
	[Address(RVA = "0x2BA9080", Offset = "0x2BA9080", VA = "0x2BA9080")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9CD")]
	[Address(RVA = "0x2BA9088", Offset = "0x2BA9088", VA = "0x2BA9088")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

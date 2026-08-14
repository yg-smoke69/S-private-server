using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002092")]
internal class UIHudCupMatchIntroController : UIBaseController
{
	[Token(Token = "0x400CC24")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCupMatchIntroView m_View;

	[Token(Token = "0x400CC25")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CC26")]
	[FieldOffset(Offset = "0x30")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CC27")]
	[FieldOffset(Offset = "0x34")]
	private bool mLocalPlayerJoined;

	[Token(Token = "0x400CC28")]
	[FieldOffset(Offset = "0x35")]
	private bool mLoadingMaskClosed;

	[Token(Token = "0x600A7C7")]
	[Address(RVA = "0x13776B8", Offset = "0x13776B8", VA = "0x13776B8")]
	public UIHudCupMatchIntroController()
	{
	}

	[Token(Token = "0x600A7C8")]
	[Address(RVA = "0x137773C", Offset = "0x137773C", VA = "0x137773C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7C9")]
	[Address(RVA = "0x13777E4", Offset = "0x13777E4", VA = "0x13777E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7CA")]
	[Address(RVA = "0x1377CC0", Offset = "0x1377CC0", VA = "0x1377CC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A7CB")]
	[Address(RVA = "0x1377A7C", Offset = "0x1377A7C", VA = "0x1377A7C")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A7CC")]
	[Address(RVA = "0x1377EC4", Offset = "0x1377EC4", VA = "0x1377EC4")]
	private void RefreshCupMatchIcon()
	{
	}

	[Token(Token = "0x600A7CD")]
	[Address(RVA = "0x137817C", Offset = "0x137817C", VA = "0x137817C")]
	private void OnLocalPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A7CE")]
	[Address(RVA = "0x1378390", Offset = "0x1378390", VA = "0x1378390")]
	private void OnLoadingMaskClosed(object[] data)
	{
	}

	[Token(Token = "0x600A7CF")]
	[Address(RVA = "0x13781EC", Offset = "0x13781EC", VA = "0x13781EC")]
	private void CheckStartDelayShow()
	{
	}

	[Token(Token = "0x600A7D0")]
	[Address(RVA = "0x1378400", Offset = "0x1378400", VA = "0x1378400")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A7D1")]
	[Address(RVA = "0x137861C", Offset = "0x137861C", VA = "0x137861C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A7D2")]
	[Address(RVA = "0x1378624", Offset = "0x1378624", VA = "0x1378624")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

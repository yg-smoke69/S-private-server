using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002501")]
internal class UIBriefProfileInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E5CD")]
	[FieldOffset(Offset = "0x28")]
	private UIBriefProfileInfoView m_View;

	[Token(Token = "0x400E5CE")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_PinItemInfo;

	[Token(Token = "0x400E5CF")]
	[FieldOffset(Offset = "0x30")]
	private AutoChangeComp m_AutoChangeComp;

	[Token(Token = "0x400E5D0")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isSelf;

	[Token(Token = "0x400E5D1")]
	[FieldOffset(Offset = "0x38")]
	private string m_NickName;

	[Token(Token = "0x400E5D2")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_AccountID;

	[Token(Token = "0x600D655")]
	[Address(RVA = "0x1445214", Offset = "0x1445214", VA = "0x1445214")]
	public UIBriefProfileInfoController()
	{
	}

	[Token(Token = "0x600D656")]
	[Address(RVA = "0x14452E0", Offset = "0x14452E0", VA = "0x14452E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D657")]
	[Address(RVA = "0x1445384", Offset = "0x1445384", VA = "0x1445384", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D658")]
	[Address(RVA = "0x1445A14", Offset = "0x1445A14", VA = "0x1445A14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D659")]
	[Address(RVA = "0x1445D98", Offset = "0x1445D98", VA = "0x1445D98")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600D65A")]
	[Address(RVA = "0x1445F44", Offset = "0x1445F44", VA = "0x1445F44")]
	private void OnBtnPinClick()
	{
	}

	[Token(Token = "0x600D65B")]
	[Address(RVA = "0x14460BC", Offset = "0x14460BC", VA = "0x14460BC")]
	public void UpdateNickName(string nickname)
	{
	}

	[Token(Token = "0x600D65C")]
	[Address(RVA = "0x14461FC", Offset = "0x14461FC", VA = "0x14461FC")]
	public void SetUIData(BaseProfileInfo info, uint showState = 0u)
	{
	}

	[Token(Token = "0x600D65D")]
	[Address(RVA = "0x1446E2C", Offset = "0x1446E2C", VA = "0x1446E2C")]
	public void UpdatePin(uint pinId)
	{
	}

	[Token(Token = "0x600D65E")]
	[Address(RVA = "0x1447038", Offset = "0x1447038", VA = "0x1447038")]
	public UISprite GetPinIcon()
	{
		return null;
	}

	[Token(Token = "0x600D65F")]
	[Address(RVA = "0x14470BC", Offset = "0x14470BC", VA = "0x14470BC")]
	public void UpdateBanner(ResourceID resId)
	{
	}

	[Token(Token = "0x600D660")]
	[Address(RVA = "0x1446D7C", Offset = "0x1446D7C", VA = "0x1446D7C")]
	public void ResetBanner()
	{
	}

	[Token(Token = "0x600D661")]
	[Address(RVA = "0x1445E38", Offset = "0x1445E38", VA = "0x1445E38")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600D662")]
	[Address(RVA = "0x144723C", Offset = "0x144723C", VA = "0x144723C")]
	private void OnMicBtnClick()
	{
	}

	[Token(Token = "0x600D663")]
	[Address(RVA = "0x144736C", Offset = "0x144736C", VA = "0x144736C")]
	private void OnSpeackerBtnClick()
	{
	}

	[Token(Token = "0x600D664")]
	[Address(RVA = "0x1446974", Offset = "0x1446974", VA = "0x1446974")]
	public void RefreshGameVoiceBtnView()
	{
	}

	[Token(Token = "0x600D665")]
	[Address(RVA = "0x14475D4", Offset = "0x14475D4", VA = "0x14475D4")]
	private void OnJoinedGameVoiceRoom(object[] data)
	{
	}

	[Token(Token = "0x600D666")]
	[Address(RVA = "0x1447648", Offset = "0x1447648", VA = "0x1447648")]
	private void OnLeavedGameVoiceRoom(object[] data)
	{
	}

	[Token(Token = "0x600D667")]
	[Address(RVA = "0x1447724", Offset = "0x1447724", VA = "0x1447724")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600D668")]
	[Address(RVA = "0x14478F4", Offset = "0x14478F4", VA = "0x14478F4")]
	private void UpdateNickNameAndAlias()
	{
	}

	[Token(Token = "0x600D669")]
	[Address(RVA = "0x1447BDC", Offset = "0x1447BDC", VA = "0x1447BDC", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D66A")]
	[Address(RVA = "0x1447C70", Offset = "0x1447C70", VA = "0x1447C70", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D66B")]
	[Address(RVA = "0x1447D3C", Offset = "0x1447D3C", VA = "0x1447D3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D66C")]
	[Address(RVA = "0x1447D44", Offset = "0x1447D44", VA = "0x1447D44")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}

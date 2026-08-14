using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F8E")]
internal class UIBigEventNaviPopBaseController : UINaviPopController
{
	[Token(Token = "0x6009CFA")]
	[Address(RVA = "0x30114D4", Offset = "0x30114D4", VA = "0x30114D4")]
	public UIBigEventNaviPopBaseController()
	{
	}

	[Token(Token = "0x6009CFB")]
	[Address(RVA = "0x30152B0", Offset = "0x30152B0", VA = "0x30152B0", Slot = "43")]
	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009CFC")]
	[Address(RVA = "0x3015308", Offset = "0x3015308", VA = "0x3015308", Slot = "44")]
	public virtual EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009CFD")]
	[Address(RVA = "0x3011594", Offset = "0x3011594", VA = "0x3011594", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6009CFE")]
	[Address(RVA = "0x3014E3C", Offset = "0x3014E3C", VA = "0x3014E3C", Slot = "45")]
	public virtual UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009CFF")]
	[Address(RVA = "0x3015360", Offset = "0x3015360", VA = "0x3015360")]
	public void GoToV2Navigation(UINavigationUtil.UINavigationFrom from, EV2NavigationPageType pageType, uint entranceId, [Optional] object extra)
	{
	}

	[Token(Token = "0x6009D00")]
	[Address(RVA = "0x301551C", Offset = "0x301551C", VA = "0x301551C")]
	public void GoToNavigation(UINavigationUtil.UINavigationFrom from, uint gopos, [Optional] string param, [Optional] object extra)
	{
	}

	[Token(Token = "0x6009D01")]
	[Address(RVA = "0x3013718", Offset = "0x3013718", VA = "0x3013718")]
	public void LogClick(string posfix)
	{
	}

	[Token(Token = "0x6009D02")]
	[Address(RVA = "0x3014C6C", Offset = "0x3014C6C", VA = "0x3014C6C")]
	public void SetCdnTextureView(UINetworkTextureExt cdnTexture, int cndType)
	{
	}

	[Token(Token = "0x6009D03")]
	[Address(RVA = "0x3015660", Offset = "0x3015660", VA = "0x3015660")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}
}

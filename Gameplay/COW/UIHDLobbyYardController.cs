using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002126")]
public class UIHDLobbyYardController : UINavigationController
{
	[Token(Token = "0x400CF9D")]
	[FieldOffset(Offset = "0x68")]
	private UIHDLobbyYardView m_View;

	[Token(Token = "0x400CF9E")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> UI3DOBJECT_NAMES;

	[Token(Token = "0x400CF9F")]
	[FieldOffset(Offset = "0x6C")]
	private float m_EnterTime;

	[Token(Token = "0x600AD8B")]
	[Address(RVA = "0x2032090", Offset = "0x2032090", VA = "0x2032090")]
	public UIHDLobbyYardController()
	{
	}

	[Token(Token = "0x600AD8C")]
	[Address(RVA = "0x2032114", Offset = "0x2032114", VA = "0x2032114")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD8D")]
	[Address(RVA = "0x20321B8", Offset = "0x20321B8", VA = "0x20321B8", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600AD8E")]
	[Address(RVA = "0x2032290", Offset = "0x2032290", VA = "0x2032290", Slot = "35")]
	protected override void AvatarCameraStateChange(UINavigationData navigationData)
	{
	}

	[Token(Token = "0x600AD8F")]
	[Address(RVA = "0x203245C", Offset = "0x203245C", VA = "0x203245C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD90")]
	[Address(RVA = "0x20327D8", Offset = "0x20327D8", VA = "0x20327D8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AD91")]
	[Address(RVA = "0x2032B14", Offset = "0x2032B14", VA = "0x2032B14", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600AD92")]
	[Address(RVA = "0x2032C24", Offset = "0x2032C24", VA = "0x2032C24", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AD93")]
	[Address(RVA = "0x2032D48", Offset = "0x2032D48", VA = "0x2032D48", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600AD94")]
	[Address(RVA = "0x2032FB8", Offset = "0x2032FB8", VA = "0x2032FB8")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x600AD95")]
	[Address(RVA = "0x20330C4", Offset = "0x20330C4", VA = "0x20330C4")]
	private void OnClickShareButton()
	{
	}

	[Token(Token = "0x600AD96")]
	[Address(RVA = "0x2033390", Offset = "0x2033390", VA = "0x2033390", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600AD97")]
	[Address(RVA = "0x2033408", Offset = "0x2033408", VA = "0x2033408", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600AD99")]
	[Address(RVA = "0x2033670", Offset = "0x2033670", VA = "0x2033670")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600AD9A")]
	[Address(RVA = "0x2033678", Offset = "0x2033678", VA = "0x2033678")]
	public void _003C_003EiFixBaseProxy_AvatarCameraStateChange(UINavigationData P0)
	{
	}

	[Token(Token = "0x600AD9B")]
	[Address(RVA = "0x2033680", Offset = "0x2033680", VA = "0x2033680")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AD9C")]
	[Address(RVA = "0x2033688", Offset = "0x2033688", VA = "0x2033688")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AD9D")]
	[Address(RVA = "0x2033690", Offset = "0x2033690", VA = "0x2033690")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600AD9E")]
	[Address(RVA = "0x2033698", Offset = "0x2033698", VA = "0x2033698")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AD9F")]
	[Address(RVA = "0x20336A0", Offset = "0x20336A0", VA = "0x20336A0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600ADA0")]
	[Address(RVA = "0x20336A8", Offset = "0x20336A8", VA = "0x20336A8")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600ADA1")]
	[Address(RVA = "0x20336B0", Offset = "0x20336B0", VA = "0x20336B0")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}

using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026FD")]
internal abstract class UIHudButtonBaseController : UIBaseController
{
	[Token(Token = "0x400F0AB")]
	[FieldOffset(Offset = "0x28")]
	protected bool IsButtonDown;

	[Token(Token = "0x600ECBB")]
	[Address(RVA = "0x1EFE7CC", Offset = "0x1EFE7CC", VA = "0x1EFE7CC")]
	protected UIHudButtonBaseController()
	{
	}

	[Token(Token = "0x600ECBC")]
	[Address(RVA = "0x1EFE850", Offset = "0x1EFE850", VA = "0x1EFE850", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ECBD")]
	[Address(RVA = "0x1EFE940", Offset = "0x1EFE940", VA = "0x1EFE940", Slot = "31")]
	protected virtual void OnBtnDown()
	{
	}

	[Token(Token = "0x600ECBE")]
	[Address(RVA = "0x1EFEA2C", Offset = "0x1EFEA2C", VA = "0x1EFEA2C", Slot = "32")]
	protected virtual void OnBtnUp()
	{
	}

	[Token(Token = "0x600ECBF")]
	[Address(RVA = "0x1EFEB18", Offset = "0x1EFEB18", VA = "0x1EFEB18", Slot = "33")]
	protected virtual void OnBtnClick()
	{
	}

	[Token(Token = "0x600ECC0")]
	[Address(RVA = "0x1EFEB6C", Offset = "0x1EFEB6C", VA = "0x1EFEB6C", Slot = "34")]
	protected virtual void OnBtnPress()
	{
	}

	[Token(Token = "0x600ECC1")]
	[Address(RVA = "0x1EFEBC0", Offset = "0x1EFEBC0", VA = "0x1EFEBC0", Slot = "35")]
	protected virtual void OnBtnRelease()
	{
	}

	[Token(Token = "0x600ECC2")]
	[Address(RVA = "0x1EFEC14", Offset = "0x1EFEC14", VA = "0x1EFEC14", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600ECC3")]
	[Address(RVA = "0x1EFEC8C", Offset = "0x1EFEC8C", VA = "0x1EFEC8C")]
	protected void InitEventTrigger(UIButton button)
	{
	}

	[Token(Token = "0x600ECC4")]
	protected abstract string GetMappingName();

	[Token(Token = "0x600ECC5")]
	[Address(RVA = "0x1EFEFA4", Offset = "0x1EFEFA4", VA = "0x1EFEFA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600ECC6")]
	[Address(RVA = "0x1EFEFAC", Offset = "0x1EFEFAC", VA = "0x1EFEFAC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}

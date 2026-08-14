using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C5")]
internal class UIPVEWeaponBtnController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D950")]
	[FieldOffset(Offset = "0x28")]
	private UIPVEWeaponBtnView m_View;

	[Token(Token = "0x400D951")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPVE m_ModelPVE;

	[Token(Token = "0x600BF6C")]
	[Address(RVA = "0x15AA2D4", Offset = "0x15AA2D4", VA = "0x15AA2D4")]
	public UIPVEWeaponBtnController()
	{
	}

	[Token(Token = "0x600BF6D")]
	[Address(RVA = "0x15AA358", Offset = "0x15AA358", VA = "0x15AA358")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF6E")]
	[Address(RVA = "0x15AA400", Offset = "0x15AA400", VA = "0x15AA400", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF6F")]
	[Address(RVA = "0x15AA7FC", Offset = "0x15AA7FC", VA = "0x15AA7FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF70")]
	[Address(RVA = "0x15AA680", Offset = "0x15AA680", VA = "0x15AA680")]
	private void RefreshPrimaryWeapon(uint itemId)
	{
	}

	[Token(Token = "0x600BF71")]
	[Address(RVA = "0x15AA950", Offset = "0x15AA950", VA = "0x15AA950")]
	private void OnWeaponBtnClick()
	{
	}

	[Token(Token = "0x600BF72")]
	[Address(RVA = "0x15AAAC8", Offset = "0x15AAAC8", VA = "0x15AAAC8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BF73")]
	[Address(RVA = "0x15AABB8", Offset = "0x15AABB8", VA = "0x15AABB8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BF74")]
	[Address(RVA = "0x15AAC4C", Offset = "0x15AAC4C", VA = "0x15AAC4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF75")]
	[Address(RVA = "0x15AAC54", Offset = "0x15AAC54", VA = "0x15AAC54")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

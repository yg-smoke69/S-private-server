using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002353")]
public class UISceneEditResMgrObjectItemController : UIEasyListItemController
{
	[Token(Token = "0x400DC12")]
	[FieldOffset(Offset = "0x38")]
	private UISceneResMgrObjectItemView m_View;

	[Token(Token = "0x400DC13")]
	[FieldOffset(Offset = "0x3C")]
	private SceneEditObjectBase m_SceneObj;

	[Token(Token = "0x400DC14")]
	[FieldOffset(Offset = "0x40")]
	private SceneEditAgent m_Agent;

	[Token(Token = "0x600C4CA")]
	[Address(RVA = "0x2DA7B54", Offset = "0x2DA7B54", VA = "0x2DA7B54")]
	public UISceneEditResMgrObjectItemController()
	{
	}

	[Token(Token = "0x600C4CB")]
	[Address(RVA = "0x2DA7B5C", Offset = "0x2DA7B5C", VA = "0x2DA7B5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C4CC")]
	[Address(RVA = "0x2DA7C00", Offset = "0x2DA7C00", VA = "0x2DA7C00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C4CD")]
	[Address(RVA = "0x2DA7DE0", Offset = "0x2DA7DE0", VA = "0x2DA7DE0")]
	private void OnResMgrObjectUnSelected(object[] data)
	{
	}

	[Token(Token = "0x600C4CE")]
	[Address(RVA = "0x2DA7F80", Offset = "0x2DA7F80", VA = "0x2DA7F80", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C4CF")]
	[Address(RVA = "0x2DA83DC", Offset = "0x2DA83DC", VA = "0x2DA83DC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C4D0")]
	[Address(RVA = "0x2DA8478", Offset = "0x2DA8478", VA = "0x2DA8478", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C4D1")]
	[Address(RVA = "0x2DA89B4", Offset = "0x2DA89B4", VA = "0x2DA89B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C4D2")]
	[Address(RVA = "0x2DA89BC", Offset = "0x2DA89BC", VA = "0x2DA89BC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C4D3")]
	[Address(RVA = "0x2DA89C4", Offset = "0x2DA89C4", VA = "0x2DA89C4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}

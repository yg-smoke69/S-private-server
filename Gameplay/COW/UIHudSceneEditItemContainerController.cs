using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002333")]
internal class UIHudSceneEditItemContainerController : UIEasyListItemController
{
	[Token(Token = "0x400DB47")]
	[FieldOffset(Offset = "0x38")]
	private UIHudSceneEditItemContainerView m_View;

	[Token(Token = "0x400DB48")]
	[FieldOffset(Offset = "0x3C")]
	private int mDataIndex;

	[Token(Token = "0x400DB49")]
	[FieldOffset(Offset = "0x40")]
	private SceneEditPrefabConfigData mPrefabData;

	[Token(Token = "0x400DB4A")]
	[FieldOffset(Offset = "0x44")]
	private UIHudSceneEditItem sceneEditItem;

	[Token(Token = "0x400DB4B")]
	[FieldOffset(Offset = "0x48")]
	private FONLAPPBCOO m_EntityLogicType;

	[Token(Token = "0x400DB4C")]
	[FieldOffset(Offset = "0x4C")]
	private bool mIsCurModeForbidden;

	[Token(Token = "0x400DB4D")]
	[FieldOffset(Offset = "0x4D")]
	private bool mIsCurItemNew;

	[Token(Token = "0x170010B9")]
	public SceneEditPrefabConfigData PrefabData
	{
		[Token(Token = "0x600C355")]
		[Address(RVA = "0x24D5584", Offset = "0x24D5584", VA = "0x24D5584")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BA")]
	public WorkShopPrefabResourceContentConfigData ConfigData
	{
		[Token(Token = "0x600C356")]
		[Address(RVA = "0x24D55DC", Offset = "0x24D55DC", VA = "0x24D55DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BB")]
	public bool IsSelected
	{
		[Token(Token = "0x600C357")]
		[Address(RVA = "0x24D5648", Offset = "0x24D5648", VA = "0x24D5648")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170010BC")]
	public FONLAPPBCOO EntityLogicType
	{
		[Token(Token = "0x600C358")]
		[Address(RVA = "0x24D56C0", Offset = "0x24D56C0", VA = "0x24D56C0")]
		get
		{
			return default(FONLAPPBCOO);
		}
	}

	[Token(Token = "0x600C354")]
	[Address(RVA = "0x24D557C", Offset = "0x24D557C", VA = "0x24D557C")]
	public UIHudSceneEditItemContainerController()
	{
	}

	[Token(Token = "0x600C359")]
	[Address(RVA = "0x24D5718", Offset = "0x24D5718", VA = "0x24D5718")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C35A")]
	[Address(RVA = "0x24D57BC", Offset = "0x24D57BC", VA = "0x24D57BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C35B")]
	[Address(RVA = "0x24D5970", Offset = "0x24D5970", VA = "0x24D5970", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C35C")]
	[Address(RVA = "0x24D5E94", Offset = "0x24D5E94", VA = "0x24D5E94")]
	public void SetSelected(bool s)
	{
	}

	[Token(Token = "0x600C35D")]
	[Address(RVA = "0x24D5F88", Offset = "0x24D5F88", VA = "0x24D5F88")]
	private void OnItemButtonClick()
	{
	}

	[Token(Token = "0x600C35E")]
	[Address(RVA = "0x24D63D8", Offset = "0x24D63D8", VA = "0x24D63D8")]
	public void TutorialClickActionBtn()
	{
	}

	[Token(Token = "0x600C35F")]
	[Address(RVA = "0x24D65B4", Offset = "0x24D65B4", VA = "0x24D65B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}

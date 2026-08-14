using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200232A")]
public class UIHudSceneEditCrosshairController : UIBaseController
{
	[Token(Token = "0x400DB2F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditCrosshairView m_View;

	[Token(Token = "0x400DB30")]
	[FieldOffset(Offset = "0x2C")]
	private bool mIsLongPressing;

	[Token(Token = "0x400DB31")]
	[FieldOffset(Offset = "0x30")]
	private float mLastStartPrepareTime;

	[Token(Token = "0x600C306")]
	[Address(RVA = "0x1C5AE74", Offset = "0x1C5AE74", VA = "0x1C5AE74")]
	public UIHudSceneEditCrosshairController()
	{
	}

	[Token(Token = "0x600C307")]
	[Address(RVA = "0x1C5AEF8", Offset = "0x1C5AEF8", VA = "0x1C5AEF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C308")]
	[Address(RVA = "0x1C5AF9C", Offset = "0x1C5AF9C", VA = "0x1C5AF9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C309")]
	[Address(RVA = "0x1C5B1C4", Offset = "0x1C5B1C4", VA = "0x1C5B1C4", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600C30A")]
	[Address(RVA = "0x1C5B360", Offset = "0x1C5B360", VA = "0x1C5B360")]
	private void Update()
	{
	}

	[Token(Token = "0x600C30B")]
	[Address(RVA = "0x1C5B54C", Offset = "0x1C5B54C", VA = "0x1C5B54C")]
	private void OnPrepareLongPressDelete(object[] param)
	{
	}

	[Token(Token = "0x600C30C")]
	[Address(RVA = "0x1C5B70C", Offset = "0x1C5B70C", VA = "0x1C5B70C")]
	private void OnPrefabChanged(object[] param)
	{
	}

	[Token(Token = "0x600C30D")]
	[Address(RVA = "0x1C5B848", Offset = "0x1C5B848", VA = "0x1C5B848")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C30E")]
	[Address(RVA = "0x1C5B850", Offset = "0x1C5B850", VA = "0x1C5B850")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}

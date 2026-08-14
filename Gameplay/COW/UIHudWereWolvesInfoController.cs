using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028B9")]
public class UIHudWereWolvesInfoController : UIBaseController
{
	[Token(Token = "0x400FAB5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesInfoView m_View;

	[Token(Token = "0x400FAB6")]
	[FieldOffset(Offset = "0x2C")]
	private float m_AlertTimer;

	[Token(Token = "0x6010067")]
	[Address(RVA = "0x2567E34", Offset = "0x2567E34", VA = "0x2567E34")]
	public UIHudWereWolvesInfoController()
	{
	}

	[Token(Token = "0x6010068")]
	[Address(RVA = "0x2567EB8", Offset = "0x2567EB8", VA = "0x2567EB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010069")]
	[Address(RVA = "0x2567F60", Offset = "0x2567F60", VA = "0x2567F60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601006A")]
	[Address(RVA = "0x2568754", Offset = "0x2568754", VA = "0x2568754", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601006B")]
	[Address(RVA = "0x2568284", Offset = "0x2568284", VA = "0x2568284")]
	private void OnCurrentPointChange(object[] data)
	{
	}

	[Token(Token = "0x601006C")]
	[Address(RVA = "0x2568958", Offset = "0x2568958", VA = "0x2568958")]
	private void OnAlertInfo(object[] data)
	{
	}

	[Token(Token = "0x601006D")]
	[Address(RVA = "0x2568C88", Offset = "0x2568C88", VA = "0x2568C88")]
	private void OnTaskCompleteTutorialCome(object[] data)
	{
	}

	[Token(Token = "0x601006E")]
	[Address(RVA = "0x2568E34", Offset = "0x2568E34", VA = "0x2568E34")]
	public void ShowFinalTaskComplete(string playerNickName)
	{
	}

	[Token(Token = "0x601006F")]
	[Address(RVA = "0x2569034", Offset = "0x2569034", VA = "0x2569034")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6010070")]
	[Address(RVA = "0x2569464", Offset = "0x2569464", VA = "0x2569464")]
	private void _003COnTaskCompleteTutorialCome_003Em__0()
	{
	}

	[Token(Token = "0x6010071")]
	[Address(RVA = "0x2569508", Offset = "0x2569508", VA = "0x2569508")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010072")]
	[Address(RVA = "0x2569510", Offset = "0x2569510", VA = "0x2569510")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}

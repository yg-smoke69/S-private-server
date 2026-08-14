using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028BE")]
public class UIHudWereWolvesTaskController : UIBaseController
{
	[Token(Token = "0x400FACB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesTaskView m_View;

	[Token(Token = "0x400FACC")]
	[FieldOffset(Offset = "0x2C")]
	private uint _uniqueId;

	[Token(Token = "0x400FACD")]
	[FieldOffset(Offset = "0x30")]
	private BaseTask m_task;

	[Token(Token = "0x400FACE")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsTaskSuccessDelayClose;

	[Token(Token = "0x6010099")]
	[Address(RVA = "0x256E89C", Offset = "0x256E89C", VA = "0x256E89C")]
	public UIHudWereWolvesTaskController()
	{
	}

	[Token(Token = "0x601009A")]
	[Address(RVA = "0x256E920", Offset = "0x256E920", VA = "0x256E920")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601009B")]
	[Address(RVA = "0x256E9C8", Offset = "0x256E9C8", VA = "0x256E9C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601009C")]
	[Address(RVA = "0x256EC78", Offset = "0x256EC78", VA = "0x256EC78", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x601009D")]
	[Address(RVA = "0x256EE14", Offset = "0x256EE14", VA = "0x256EE14")]
	private void OnNoTask(object[] data)
	{
	}

	[Token(Token = "0x601009E")]
	[Address(RVA = "0x256EF08", Offset = "0x256EF08", VA = "0x256EF08")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x601009F")]
	[Address(RVA = "0x256F354", Offset = "0x256F354", VA = "0x256F354", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60100A0")]
	[Address(RVA = "0x256F4E0", Offset = "0x256F4E0", VA = "0x256F4E0")]
	private void OnTaskComplete()
	{
	}

	[Token(Token = "0x60100A1")]
	[Address(RVA = "0x256F798", Offset = "0x256F798", VA = "0x256F798")]
	private void OnTaskCompletePost()
	{
	}

	[Token(Token = "0x60100A2")]
	[Address(RVA = "0x256F7F8", Offset = "0x256F7F8", VA = "0x256F7F8")]
	private void OnBtnTaskClick(object[] data)
	{
	}

	[Token(Token = "0x60100A3")]
	[Address(RVA = "0x256F994", Offset = "0x256F994", VA = "0x256F994")]
	private void CreateTask()
	{
	}

	[Token(Token = "0x60100A4")]
	[Address(RVA = "0x256FF4C", Offset = "0x256FF4C", VA = "0x256FF4C")]
	public void SetData(uint uniqueId)
	{
	}

	[Token(Token = "0x60100A5")]
	[Address(RVA = "0x256F114", Offset = "0x256F114", VA = "0x256F114")]
	public void CloseTask()
	{
	}

	[Token(Token = "0x60100A6")]
	[Address(RVA = "0x256FFAC", Offset = "0x256FFAC", VA = "0x256FFAC")]
	public void SuccessDelayCloseTask()
	{
	}

	[Token(Token = "0x60100A7")]
	[Address(RVA = "0x257008C", Offset = "0x257008C", VA = "0x257008C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60100A8")]
	[Address(RVA = "0x2570094", Offset = "0x2570094", VA = "0x2570094")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x60100A9")]
	[Address(RVA = "0x257009C", Offset = "0x257009C", VA = "0x257009C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}

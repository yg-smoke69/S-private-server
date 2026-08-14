using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AC7")]
public class TaskAuto : BaseTask
{
	[Token(Token = "0x4018F9B")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar progressBar;

	[Token(Token = "0x4018F9C")]
	[FieldOffset(Offset = "0x4C")]
	public UICustomHoverButton button;

	[Token(Token = "0x4018F9D")]
	[FieldOffset(Offset = "0x50")]
	public bool needPress;

	[Token(Token = "0x4018F9E")]
	[FieldOffset(Offset = "0x54")]
	public float completeTime;

	[Token(Token = "0x4018F9F")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsRun;

	[Token(Token = "0x4018FA0")]
	[FieldOffset(Offset = "0x5C")]
	private float m_CurTime;

	[Token(Token = "0x4018FA1")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsTaskFinished;

	[Token(Token = "0x6017464")]
	[Address(RVA = "0x2894FDC", Offset = "0x2894FDC", VA = "0x2894FDC")]
	public TaskAuto()
	{
	}

	[Token(Token = "0x6017465")]
	[Address(RVA = "0x2894FF0", Offset = "0x2894FF0", VA = "0x2894FF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017466")]
	[Address(RVA = "0x2895198", Offset = "0x2895198", VA = "0x2895198", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017467")]
	[Address(RVA = "0x2895264", Offset = "0x2895264", VA = "0x2895264")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6017468")]
	[Address(RVA = "0x28952DC", Offset = "0x28952DC", VA = "0x28952DC")]
	private void OnPress(bool isPress)
	{
	}

	[Token(Token = "0x6017469")]
	[Address(RVA = "0x2895380", Offset = "0x2895380", VA = "0x2895380")]
	protected void Update()
	{
	}

	[Token(Token = "0x601746A")]
	[Address(RVA = "0x289547C", Offset = "0x289547C", VA = "0x289547C", Slot = "10")]
	protected virtual void OnProgressUpdate(float progress)
	{
	}

	[Token(Token = "0x601746B")]
	[Address(RVA = "0x28954D8", Offset = "0x28954D8", VA = "0x28954D8", Slot = "8")]
	public override void Pause()
	{
	}

	[Token(Token = "0x601746C")]
	[Address(RVA = "0x2895548", Offset = "0x2895548", VA = "0x2895548", Slot = "5")]
	public override void OnSuccess()
	{
	}

	[Token(Token = "0x601746D")]
	[Address(RVA = "0x28955D4", Offset = "0x28955D4", VA = "0x28955D4")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x601746E")]
	[Address(RVA = "0x28955DC", Offset = "0x28955DC", VA = "0x28955DC")]
	public void _003C_003EiFixBaseProxy_Pause()
	{
	}

	[Token(Token = "0x601746F")]
	[Address(RVA = "0x28955E4", Offset = "0x28955E4", VA = "0x28955E4")]
	public void _003C_003EiFixBaseProxy_OnSuccess()
	{
	}
}

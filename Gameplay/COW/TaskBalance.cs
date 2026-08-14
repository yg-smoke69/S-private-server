using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AC9")]
public class TaskBalance : BaseTask
{
	[Token(Token = "0x4018FA3")]
	[FieldOffset(Offset = "0x48")]
	public new UITweener[] animations;

	[Token(Token = "0x4018FA4")]
	[FieldOffset(Offset = "0x4C")]
	public TaskDragDropContainer dragDropContainer;

	[Token(Token = "0x4018FA5")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsComplete;

	[Token(Token = "0x4018FA6")]
	[FieldOffset(Offset = "0x54")]
	public string balanceSound;

	[Token(Token = "0x4018FA7")]
	[FieldOffset(Offset = "0x58")]
	private ResourceID m_resBalanceSound;

	[Token(Token = "0x6017475")]
	[Address(RVA = "0x28957AC", Offset = "0x28957AC", VA = "0x28957AC")]
	public TaskBalance()
	{
	}

	[Token(Token = "0x6017476")]
	[Address(RVA = "0x28957B4", Offset = "0x28957B4", VA = "0x28957B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017477")]
	[Address(RVA = "0x2895938", Offset = "0x2895938", VA = "0x2895938", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017478")]
	[Address(RVA = "0x2895AB0", Offset = "0x2895AB0", VA = "0x2895AB0")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x6017479")]
	[Address(RVA = "0x2895C6C", Offset = "0x2895C6C", VA = "0x2895C6C")]
	private void Update()
	{
	}

	[Token(Token = "0x601747A")]
	[Address(RVA = "0x2895CD8", Offset = "0x2895CD8", VA = "0x2895CD8")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}

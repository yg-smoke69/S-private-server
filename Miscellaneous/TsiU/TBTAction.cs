using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C18")]
public abstract class TBTAction : TBTTreeNode
{
	[Token(Token = "0x40199F7")]
	[FieldOffset(Offset = "0x0")]
	private static int sUNIQUEKEY;

	[Token(Token = "0x40199F8")]
	[FieldOffset(Offset = "0x10")]
	protected int _uniqueKey;

	[Token(Token = "0x40199F9")]
	[FieldOffset(Offset = "0x14")]
	protected TBTPrecondition _precondition;

	[Token(Token = "0x6018004")]
	[Address(RVA = "0x263F5E8", Offset = "0x263F5E8", VA = "0x263F5E8")]
	public TBTAction(int maxChildCount)
	{
	}

	[Token(Token = "0x6018005")]
	[Address(RVA = "0x263F740", Offset = "0x263F740", VA = "0x263F740")]
	private static int genUniqueKey()
	{
		return default(int);
	}

	[Token(Token = "0x6018006")]
	[Address(RVA = "0x263F88C", Offset = "0x263F88C", VA = "0x263F88C", Slot = "1")]
	~TBTAction()
	{
	}

	[Token(Token = "0x6018007")]
	[Address(RVA = "0x263F8B0", Offset = "0x263F8B0", VA = "0x263F8B0")]
	public bool Evaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x6018008")]
	[Address(RVA = "0x263F908", Offset = "0x263F908", VA = "0x263F908")]
	public int Update(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x6018009")]
	[Address(RVA = "0x263F918", Offset = "0x263F918", VA = "0x263F918")]
	public void Transition(TBTWorkingData wData)
	{
	}

	[Token(Token = "0x601800A")]
	[Address(RVA = "0x263F928", Offset = "0x263F928", VA = "0x263F928")]
	public TBTAction SetPrecondition(TBTPrecondition precondition)
	{
		return null;
	}

	[Token(Token = "0x601800B")]
	[Address(RVA = "0x263F930", Offset = "0x263F930", VA = "0x263F930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x601800C")]
	protected T getContext<T>(TBTWorkingData wData) where T : TBTActionContext, new()
	{
		return null;
	}

	[Token(Token = "0x601800D")]
	[Address(RVA = "0x263F938", Offset = "0x263F938", VA = "0x263F938", Slot = "4")]
	protected virtual bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x601800E")]
	[Address(RVA = "0x263F940", Offset = "0x263F940", VA = "0x263F940", Slot = "5")]
	protected virtual int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x601800F")]
	[Address(RVA = "0x263F948", Offset = "0x263F948", VA = "0x263F948", Slot = "6")]
	protected virtual void onTransition(TBTWorkingData wData)
	{
	}
}

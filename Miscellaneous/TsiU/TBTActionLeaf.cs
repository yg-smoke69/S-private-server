using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C19")]
public abstract class TBTActionLeaf : TBTAction
{
	[Token(Token = "0x2003C1A")]
	private class TBTActionLeafContext : TBTActionContext
	{
		[Token(Token = "0x40199FD")]
		[FieldOffset(Offset = "0x8")]
		internal int status;

		[Token(Token = "0x40199FE")]
		[FieldOffset(Offset = "0xC")]
		internal bool needExit;

		[Token(Token = "0x40199FF")]
		[FieldOffset(Offset = "0x10")]
		private object _userData;

		[Token(Token = "0x6018018")]
		[Address(RVA = "0x263FC00", Offset = "0x263FC00", VA = "0x263FC00")]
		public TBTActionLeafContext()
		{
		}

		[Token(Token = "0x6018019")]
		public T getUserData<T>() where T : class, new()
		{
			return null;
		}
	}

	[Token(Token = "0x40199FA")]
	private const int ACTION_READY = 0;

	[Token(Token = "0x40199FB")]
	private const int ACTION_RUNNING = 1;

	[Token(Token = "0x40199FC")]
	private const int ACTION_FINISHED = 2;

	[Token(Token = "0x6018011")]
	[Address(RVA = "0x263F958", Offset = "0x263F958", VA = "0x263F958")]
	public TBTActionLeaf()
	{
	}

	[Token(Token = "0x6018012")]
	[Address(RVA = "0x263F9DC", Offset = "0x263F9DC", VA = "0x263F9DC", Slot = "5")]
	protected sealed override int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x6018013")]
	[Address(RVA = "0x263FB3C", Offset = "0x263FB3C", VA = "0x263FB3C", Slot = "6")]
	protected sealed override void onTransition(TBTWorkingData wData)
	{
	}

	[Token(Token = "0x6018014")]
	protected T getUserContexData<T>(TBTWorkingData wData) where T : class, new()
	{
		return null;
	}

	[Token(Token = "0x6018015")]
	[Address(RVA = "0x263FBF0", Offset = "0x263FBF0", VA = "0x263FBF0", Slot = "7")]
	protected virtual void onEnter(TBTWorkingData wData)
	{
	}

	[Token(Token = "0x6018016")]
	[Address(RVA = "0x263FBF4", Offset = "0x263FBF4", VA = "0x263FBF4", Slot = "8")]
	protected virtual int onExecute(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x6018017")]
	[Address(RVA = "0x263FBFC", Offset = "0x263FBFC", VA = "0x263FBFC", Slot = "9")]
	protected virtual void onExit(TBTWorkingData wData, int runningStatus)
	{
	}
}

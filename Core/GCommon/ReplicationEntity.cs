using Il2CppDummyDll;
using message;

namespace GCommon;

[Token(Token = "0x2003EDF")]
public abstract class ReplicationEntity : Entity
{
	[Token(Token = "0x401A89A")]
	[FieldOffset(Offset = "0x34")]
	protected bool m_IsPRIRecivedFirstTime;

	[Token(Token = "0x401A89B")]
	[FieldOffset(Offset = "0x38")]
	protected IPRIDataPool m_PRIDataPool;

	[Token(Token = "0x401A89C")]
	[FieldOffset(Offset = "0x3C")]
	private AAAIAPOBKND _003CReplicationEntityTag_003Ek__BackingField;

	[Token(Token = "0x17001BFB")]
	public AAAIAPOBKND ReplicationEntityTag
	{
		[Token(Token = "0x60199A8")]
		[Address(RVA = "0x3330178", Offset = "0x3330178", VA = "0x3330178")]
		get
		{
			return default(AAAIAPOBKND);
		}
		[Token(Token = "0x60199A9")]
		[Address(RVA = "0x3330180", Offset = "0x3330180", VA = "0x3330180")]
		set
		{
		}
	}

	[Token(Token = "0x60199A7")]
	[Address(RVA = "0x33300EC", Offset = "0x33300EC", VA = "0x33300EC")]
	protected ReplicationEntity()
	{
	}

	[Token(Token = "0x60199AA")]
	[Address(RVA = "0x3330188", Offset = "0x3330188", VA = "0x3330188", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60199AB")]
	[Address(RVA = "0x3330190", Offset = "0x3330190", VA = "0x3330190", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60199AC")]
	[Address(RVA = "0x33303A4", Offset = "0x33303A4", VA = "0x33303A4", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60199AD")]
	[Address(RVA = "0x3330204", Offset = "0x3330204", VA = "0x3330204")]
	public void OnReplicationBind(uint replicationID)
	{
	}

	[Token(Token = "0x60199AE")]
	[Address(RVA = "0x33303D0", Offset = "0x33303D0", VA = "0x33303D0")]
	public void OnSyncReplicationData(FastBinaryReader reader)
	{
	}

	[Token(Token = "0x60199AF")]
	[Address(RVA = "0x33304D0", Offset = "0x33304D0", VA = "0x33304D0")]
	public uint GetReplicationID()
	{
		return default(uint);
	}

	[Token(Token = "0x60199B0")]
	[Address(RVA = "0x333036C", Offset = "0x333036C", VA = "0x333036C")]
	private void InvokeInitialCallback()
	{
	}

	[Token(Token = "0x60199B1")]
	[Address(RVA = "0x33305A8", Offset = "0x33305A8", VA = "0x33305A8", Slot = "24")]
	protected virtual void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60199B2")]
	[Address(RVA = "0x33305AC", Offset = "0x33305AC", VA = "0x33305AC", Slot = "25")]
	protected virtual void OnPRIInitialized()
	{
	}

	[Token(Token = "0x60199B3")]
	protected abstract int GetMaxRepDataCount();

	[Token(Token = "0x60199B4")]
	protected abstract bool IsLocalEntity();

	[Token(Token = "0x60199B5")]
	protected abstract void RegisterEntity();

	[Token(Token = "0x60199B6")]
	protected abstract void UnRegisterEntity();
}

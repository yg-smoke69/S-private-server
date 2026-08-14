using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000062")]
internal class SDKIAPTaskInstance
{
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x8")]
	private SDKIAPTaskInfo _003CInfo_003Ek__BackingField;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0xC")]
	private SDKIAPTaskState m_TaskState;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x10")]
	private SDKIAPTaskResult _003CResult_003Ek__BackingField;

	[Token(Token = "0x1700005B")]
	public SDKIAPTaskInfo Info
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3452C70", Offset = "0x3452C70", VA = "0x3452C70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3464A84", Offset = "0x3464A84", VA = "0x3464A84")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public virtual SDKIAPTask Task
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x3464A94", Offset = "0x3464A94", VA = "0x3464A94", Slot = "4")]
		get
		{
			return default(SDKIAPTask);
		}
	}

	[Token(Token = "0x1700005D")]
	public virtual SDKIAPTaskState TaskState
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3464A9C", Offset = "0x3464A9C", VA = "0x3464A9C", Slot = "5")]
		get
		{
			return default(SDKIAPTaskState);
		}
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3464AA4", Offset = "0x3464AA4", VA = "0x3464AA4", Slot = "6")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public virtual SDKIAPTaskResult Result
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3464E7C", Offset = "0x3464E7C", VA = "0x3464E7C", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x3464E84", Offset = "0x3464E84", VA = "0x3464E84", Slot = "8")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x3452AEC", Offset = "0x3452AEC", VA = "0x3452AEC")]
	public SDKIAPTaskInstance(SDKIAPTaskInfo info)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x3464E8C", Offset = "0x3464E8C", VA = "0x3464E8C", Slot = "9")]
	internal virtual string IdentifySelf()
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x3464F18", Offset = "0x3464F18", VA = "0x3464F18", Slot = "10")]
	public virtual bool IsGoodToGo()
	{
		return default(bool);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3452E08", Offset = "0x3452E08", VA = "0x3452E08", Slot = "11")]
	public virtual bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3452FAC", Offset = "0x3452FAC", VA = "0x3452FAC", Slot = "12")]
	public virtual bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3464AB4", Offset = "0x3464AB4", VA = "0x3464AB4")]
	private void StateChanged(SDKIAPTaskState prev, SDKIAPTaskState next)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x34531B0", Offset = "0x34531B0", VA = "0x34531B0", Slot = "13")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x3453490", Offset = "0x3453490", VA = "0x3453490", Slot = "14")]
	protected virtual void Succeed()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x345356C", Offset = "0x345356C", VA = "0x345356C", Slot = "15")]
	protected virtual void Fail()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x3453600", Offset = "0x3453600", VA = "0x3453600", Slot = "16")]
	protected virtual void Destroy()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x3464F20", Offset = "0x3464F20", VA = "0x3464F20", Slot = "17")]
	protected virtual void Retry()
	{
	}
}

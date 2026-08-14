using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C1E")]
public class TBTActionParallel : TBTAction
{
	[Token(Token = "0x2003C1F")]
	public enum ECHILDREN_RELATIONSHIP
	{
		[Token(Token = "0x4019A06")]
		AND,
		[Token(Token = "0x4019A07")]
		OR
	}

	[Token(Token = "0x2003C20")]
	protected class TBTActionParallelContext : TBTActionContext
	{
		[Token(Token = "0x4019A08")]
		[FieldOffset(Offset = "0x8")]
		internal List<bool> evaluationStatus;

		[Token(Token = "0x4019A09")]
		[FieldOffset(Offset = "0xC")]
		internal List<int> runningStatus;

		[Token(Token = "0x6018029")]
		[Address(RVA = "0x2640A9C", Offset = "0x2640A9C", VA = "0x2640A9C")]
		public TBTActionParallelContext()
		{
		}
	}

	[Token(Token = "0x4019A03")]
	[FieldOffset(Offset = "0x18")]
	private ECHILDREN_RELATIONSHIP _evaluationRelationship;

	[Token(Token = "0x4019A04")]
	[FieldOffset(Offset = "0x1C")]
	private ECHILDREN_RELATIONSHIP _runningStatusRelationship;

	[Token(Token = "0x6018022")]
	[Address(RVA = "0x26403BC", Offset = "0x26403BC", VA = "0x26403BC")]
	public TBTActionParallel()
	{
	}

	[Token(Token = "0x6018023")]
	[Address(RVA = "0x2640450", Offset = "0x2640450", VA = "0x2640450")]
	public TBTActionParallel SetEvaluationRelationship(ECHILDREN_RELATIONSHIP v)
	{
		return null;
	}

	[Token(Token = "0x6018024")]
	[Address(RVA = "0x2640458", Offset = "0x2640458", VA = "0x2640458")]
	public TBTActionParallel SetRunningStatusRelationship(ECHILDREN_RELATIONSHIP v)
	{
		return null;
	}

	[Token(Token = "0x6018025")]
	[Address(RVA = "0x2640460", Offset = "0x2640460", VA = "0x2640460", Slot = "4")]
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x6018026")]
	[Address(RVA = "0x2640690", Offset = "0x2640690", VA = "0x2640690", Slot = "5")]
	protected override int onUpdate(TBTWorkingData wData)
	{
		return default(int);
	}

	[Token(Token = "0x6018027")]
	[Address(RVA = "0x264098C", Offset = "0x264098C", VA = "0x264098C", Slot = "6")]
	protected override void onTransition(TBTWorkingData wData)
	{
	}

	[Token(Token = "0x6018028")]
	private void initListTo<T>(List<T> list, T value)
	{
	}
}

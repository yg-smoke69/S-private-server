using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ECE")]
public class AnimationConfigData : CSVBaseData
{
	[Token(Token = "0x401A853")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, int> sGenID;

	[Token(Token = "0x401A854")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<int, AnimationConfigData> hashToData;

	[Token(Token = "0x401A855")]
	[FieldOffset(Offset = "0x8")]
	public AnimationID AnimID;

	[Token(Token = "0x401A856")]
	[FieldOffset(Offset = "0xC")]
	public string AnimIDName;

	[Token(Token = "0x401A857")]
	[FieldOffset(Offset = "0x10")]
	public string TargetStateName;

	[Token(Token = "0x401A858")]
	[FieldOffset(Offset = "0x14")]
	public float TransitionDuration;

	[Token(Token = "0x401A859")]
	[FieldOffset(Offset = "0x18")]
	public bool NeedWaitForFinished;

	[Token(Token = "0x401A85A")]
	[FieldOffset(Offset = "0x1C")]
	public float EndCutTime;

	[Token(Token = "0x401A85B")]
	[FieldOffset(Offset = "0x20")]
	public bool ToDefault;

	[Token(Token = "0x401A85C")]
	[FieldOffset(Offset = "0x24")]
	public AnimationID FinishedID;

	[Token(Token = "0x401A85D")]
	[FieldOffset(Offset = "0x28")]
	public bool NeedDynamicLoad;

	[Token(Token = "0x401A85E")]
	[FieldOffset(Offset = "0x2C")]
	public string[] ResourceName;

	[Token(Token = "0x6019904")]
	[Address(RVA = "0x26B3D08", Offset = "0x26B3D08", VA = "0x26B3D08")]
	public AnimationConfigData()
	{
	}

	[Token(Token = "0x6019905")]
	[Address(RVA = "0x26B3E54", Offset = "0x26B3E54", VA = "0x26B3E54")]
	private static int GetNextID(int layerIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6019906")]
	[Address(RVA = "0x26B3FAC", Offset = "0x26B3FAC", VA = "0x26B3FAC")]
	public static void OnCleanup()
	{
	}

	[Token(Token = "0x6019907")]
	[Address(RVA = "0x26B4068", Offset = "0x26B4068", VA = "0x26B4068")]
	public static AnimationConfigData GetFinishConfigData(int hash)
	{
		return null;
	}

	[Token(Token = "0x6019908")]
	[Address(RVA = "0x26B413C", Offset = "0x26B413C", VA = "0x26B413C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6019909")]
	[Address(RVA = "0x26B4144", Offset = "0x26B4144", VA = "0x26B4144")]
	private AnimationID GetAnimationID(string from, int layer)
	{
		return default(AnimationID);
	}

	[Token(Token = "0x601990A")]
	[Address(RVA = "0x26B45A0", Offset = "0x26B45A0", VA = "0x26B45A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}

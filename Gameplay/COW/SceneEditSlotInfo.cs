using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003225")]
public class SceneEditSlotInfo
{
	[Token(Token = "0x4013134")]
	[FieldOffset(Offset = "0x8")]
	public proto.EWorkshop.SlotType SlotType;

	[Token(Token = "0x4013135")]
	[FieldOffset(Offset = "0xC")]
	public uint SlotId;

	[Token(Token = "0x4013136")]
	[FieldOffset(Offset = "0x10")]
	public proto.EWorkshop.SlotState SlotState;

	[Token(Token = "0x4013137")]
	[FieldOffset(Offset = "0x14")]
	public string Name;

	[Token(Token = "0x4013138")]
	[FieldOffset(Offset = "0x18")]
	public ulong AuthorId;

	[Token(Token = "0x4013139")]
	[FieldOffset(Offset = "0x20")]
	public ulong PrefCost;

	[Token(Token = "0x401313A")]
	[FieldOffset(Offset = "0x28")]
	public long UpdateTime;

	[Token(Token = "0x401313B")]
	[FieldOffset(Offset = "0x30")]
	public ulong ResCnt;

	[Token(Token = "0x401313C")]
	[FieldOffset(Offset = "0x38")]
	public string ShareCode;

	[Token(Token = "0x401313D")]
	[FieldOffset(Offset = "0x3C")]
	public string AuthorName;

	[Token(Token = "0x401313E")]
	[FieldOffset(Offset = "0x40")]
	public ulong LikeCount;

	[Token(Token = "0x401313F")]
	[FieldOffset(Offset = "0x48")]
	public ulong SubCount;

	[Token(Token = "0x4013140")]
	[FieldOffset(Offset = "0x50")]
	public uint[] Tags;

	[Token(Token = "0x4013141")]
	[FieldOffset(Offset = "0x54")]
	public uint GameMode;

	[Token(Token = "0x4013142")]
	[FieldOffset(Offset = "0x58")]
	public uint GroupMode;

	[Token(Token = "0x4013143")]
	[FieldOffset(Offset = "0x5C")]
	public string WorkShopDesc;

	[Token(Token = "0x4013144")]
	[FieldOffset(Offset = "0x60")]
	public FEIGJAGLKLM ModeSettings;

	[Token(Token = "0x4013145")]
	[FieldOffset(Offset = "0x64")]
	public byte[] BitMiniMap;

	[Token(Token = "0x4013146")]
	[FieldOffset(Offset = "0x68")]
	public byte[] IconMiniMap;

	[Token(Token = "0x4013147")]
	[FieldOffset(Offset = "0x6C")]
	public uint TeamCount;

	[Token(Token = "0x4013148")]
	[FieldOffset(Offset = "0x70")]
	public uint MapId;

	[Token(Token = "0x4013149")]
	[FieldOffset(Offset = "0x74")]
	public List<NCPHFLKMCKL.NOJMKKPDDFM> UserDefinedStrings;

	[Token(Token = "0x401314A")]
	[FieldOffset(Offset = "0x78")]
	public ulong RuntimeDataLength;

	[Token(Token = "0x401314B")]
	[FieldOffset(Offset = "0x80")]
	public ulong ProjectDataLength;

	[Token(Token = "0x401314C")]
	[FieldOffset(Offset = "0x88")]
	public byte[] RuntimeDataMD5;

	[Token(Token = "0x401314D")]
	[FieldOffset(Offset = "0x8C")]
	public byte[] ProjectDataMD5;

	[Token(Token = "0x401314E")]
	[FieldOffset(Offset = "0x90")]
	public bool LocalSave;

	[Token(Token = "0x401314F")]
	[FieldOffset(Offset = "0x94")]
	public List<WorkshopCommentTag> CommentTags;

	[Token(Token = "0x4013150")]
	[FieldOffset(Offset = "0x98")]
	public proto.EWorkshop.EditorType EditorType;

	[Token(Token = "0x601521A")]
	[Address(RVA = "0x24214B8", Offset = "0x24214B8", VA = "0x24214B8")]
	public SceneEditSlotInfo()
	{
	}

	[Token(Token = "0x601521B")]
	[Address(RVA = "0x2421544", Offset = "0x2421544", VA = "0x2421544", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601521C")]
	[Address(RVA = "0x242161C", Offset = "0x242161C", VA = "0x242161C")]
	public bool IsLocked()
	{
		return default(bool);
	}

	[Token(Token = "0x601521D")]
	[Address(RVA = "0x2421688", Offset = "0x2421688", VA = "0x2421688")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x601521E")]
	[Address(RVA = "0x24216F4", Offset = "0x24216F4", VA = "0x24216F4")]
	public bool IsFE()
	{
		return default(bool);
	}

	[Token(Token = "0x601521F")]
	[Address(RVA = "0x2421758", Offset = "0x2421758", VA = "0x2421758")]
	public static implicit operator SceneEditSlotInfo(WorkshopAuthorSlotInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015220")]
	[Address(RVA = "0x2421B50", Offset = "0x2421B50", VA = "0x2421B50")]
	public static implicit operator SceneEditSlotInfo(WorkshopSubscribeSlotInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015221")]
	[Address(RVA = "0x2421C90", Offset = "0x2421C90", VA = "0x2421C90")]
	public static implicit operator SceneEditSlotInfo(WorkshopClassicSlotInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015222")]
	[Address(RVA = "0x2421DD0", Offset = "0x2421DD0", VA = "0x2421DD0")]
	public static implicit operator SceneEditSlotInfo(WorkshopBasicInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015223")]
	[Address(RVA = "0x2421EA0", Offset = "0x2421EA0", VA = "0x2421EA0")]
	public static implicit operator SceneEditSlotInfo(WorkshopPersonalRecommendationInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015224")]
	[Address(RVA = "0x2421FA8", Offset = "0x2421FA8", VA = "0x2421FA8")]
	public static implicit operator SceneEditSlotInfo(WorkshopLatestInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015225")]
	[Address(RVA = "0x24220CC", Offset = "0x24220CC", VA = "0x24220CC")]
	public static implicit operator SceneEditSlotInfo(WorkshopHotInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015226")]
	[Address(RVA = "0x24221D4", Offset = "0x24221D4", VA = "0x24221D4")]
	public static implicit operator SceneEditSlotInfo(WorkshopEditorChoiceInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015227")]
	[Address(RVA = "0x24222DC", Offset = "0x24222DC", VA = "0x24222DC")]
	public static implicit operator SceneEditSlotInfo(tcp.RoomInfo data)
	{
		return null;
	}

	[Token(Token = "0x6015228")]
	[Address(RVA = "0x2422670", Offset = "0x2422670", VA = "0x2422670")]
	public static implicit operator SceneEditSlotInfo(PGBGOAOCGDC data)
	{
		return null;
	}

	[Token(Token = "0x6015229")]
	[Address(RVA = "0x2422BA4", Offset = "0x2422BA4", VA = "0x2422BA4")]
	public void SetEmpty()
	{
	}

	[Token(Token = "0x601522A")]
	[Address(RVA = "0x2422D88", Offset = "0x2422D88", VA = "0x2422D88")]
	public void CopyBasicInfoFrom(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x601522B")]
	[Address(RVA = "0x242192C", Offset = "0x242192C", VA = "0x242192C")]
	public void CopyBasicInfoFrom(WorkshopBasicInfo info)
	{
	}

	[Token(Token = "0x601522C")]
	[Address(RVA = "0x2423078", Offset = "0x2423078", VA = "0x2423078")]
	public static implicit operator PGBGOAOCGDC(SceneEditSlotInfo info)
	{
		return null;
	}

	[Token(Token = "0x601522D")]
	[Address(RVA = "0x24235F8", Offset = "0x24235F8", VA = "0x24235F8")]
	public bool SaveAsUGCMetaData()
	{
		return default(bool);
	}

	[Token(Token = "0x601522E")]
	[Address(RVA = "0x242366C", Offset = "0x242366C", VA = "0x242366C")]
	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}

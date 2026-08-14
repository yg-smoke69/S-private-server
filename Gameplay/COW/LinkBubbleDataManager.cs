using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000177")]
public class LinkBubbleDataManager : SingletonModule<LinkBubbleDataManager>
{
	[Token(Token = "0x2000178")]
	private sealed class _003CGetDataByBubbleID_003Ec__AnonStorey0
	{
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x8")]
		internal uint bubbleid;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xEC78D4", Offset = "0xEC78D4", VA = "0xEC78D4")]
		public _003CGetDataByBubbleID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xEC7F78", Offset = "0xEC7F78", VA = "0xEC7F78")]
		internal bool _003C_003Em__0(LinkBubbleData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000179")]
	private sealed class _003CGetDataByAvatarID_003Ec__AnonStorey1
	{
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xEC7A54", Offset = "0xEC7A54", VA = "0xEC7A54")]
		public _003CGetDataByAvatarID_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xEC7F1C", Offset = "0xEC7F1C", VA = "0xEC7F1C")]
		internal bool _003C_003Em__0(LinkBubbleData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017A")]
	private sealed class _003CGetDataByAvatarIDWithCondition_003Ec__AnonStorey2
	{
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0xC")]
		internal uint condition;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xEC7C04", Offset = "0xEC7C04", VA = "0xEC7C04")]
		public _003CGetDataByAvatarIDWithCondition_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xEC7F40", Offset = "0xEC7F40", VA = "0xEC7F40")]
		internal bool _003C_003Em__0(LinkBubbleData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017B")]
	private sealed class _003CIsNewBubbleUnlocked_003Ec__AnonStorey3
	{
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0xC")]
		internal uint oldValue;

		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x10")]
		internal uint newValue;

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xEC7F14", Offset = "0xEC7F14", VA = "0xEC7F14")]
		public _003CIsNewBubbleUnlocked_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xEC7F9C", Offset = "0xEC7F9C", VA = "0xEC7F9C")]
		internal bool _003C_003Em__0(LinkBubbleData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0xC")]
	private List<LinkBubbleData> m_DataList;

	[Token(Token = "0x600088F")]
	[Address(RVA = "0xEC74E8", Offset = "0xEC74E8", VA = "0xEC74E8")]
	public LinkBubbleDataManager()
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0xEC7578", Offset = "0xEC7578", VA = "0xEC7578", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0xEC7638", Offset = "0xEC7638", VA = "0xEC7638", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0xEC775C", Offset = "0xEC775C", VA = "0xEC775C")]
	public LinkBubbleData GetDataByBubbleID(uint bubbleid)
	{
		return null;
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0xEC78DC", Offset = "0xEC78DC", VA = "0xEC78DC")]
	public List<LinkBubbleData> GetDataByAvatarID(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0xEC7A5C", Offset = "0xEC7A5C", VA = "0xEC7A5C")]
	public List<LinkBubbleData> GetDataByAvatarIDWithCondition(uint avatarID, uint condition)
	{
		return null;
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0xEC7C0C", Offset = "0xEC7C0C", VA = "0xEC7C0C")]
	public bool IsNewBubbleUnlocked(uint avatarID, uint oldValue, uint newValue)
	{
		return default(bool);
	}
}

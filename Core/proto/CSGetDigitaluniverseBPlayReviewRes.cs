using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001963")]
public class CSGetDigitaluniverseBPlayReviewRes
{
	[Token(Token = "0x2001964")]
	public class EventReviewData
	{
		[Token(Token = "0x4009FA6")]
		[FieldOffset(Offset = "0x8")]
		public uint event_id;

		[Token(Token = "0x4009FA7")]
		[FieldOffset(Offset = "0xC")]
		public uint signin_reward_times;

		[Token(Token = "0x4009FA8")]
		[FieldOffset(Offset = "0x10")]
		public uint peakday_reward_times;

		[Token(Token = "0x4009FA9")]
		[FieldOffset(Offset = "0x14")]
		public uint[] event_data;

		[Token(Token = "0x6007FBD")]
		[Address(RVA = "0x3183ED0", Offset = "0x3183ED0", VA = "0x3183ED0")]
		public EventReviewData()
		{
		}
	}

	[Token(Token = "0x2001965")]
	public class CollectionReviewData
	{
		[Token(Token = "0x4009FAA")]
		[FieldOffset(Offset = "0x8")]
		public uint collection_id;

		[Token(Token = "0x4009FAB")]
		[FieldOffset(Offset = "0xC")]
		public uint kills;

		[Token(Token = "0x4009FAC")]
		[FieldOffset(Offset = "0x10")]
		public uint match_cnt;

		[Token(Token = "0x4009FAD")]
		[FieldOffset(Offset = "0x14")]
		public uint booyah_cnt;

		[Token(Token = "0x4009FAE")]
		[FieldOffset(Offset = "0x18")]
		public uint headshot_cnt;

		[Token(Token = "0x6007FBE")]
		[Address(RVA = "0x3183EC8", Offset = "0x3183EC8", VA = "0x3183EC8")]
		public CollectionReviewData()
		{
		}
	}

	[Token(Token = "0x2001966")]
	public class ClothReviewData
	{
		[Token(Token = "0x4009FAF")]
		[FieldOffset(Offset = "0x8")]
		public uint anniversary_order;

		[Token(Token = "0x4009FB0")]
		[FieldOffset(Offset = "0xC")]
		public bool owned;

		[Token(Token = "0x6007FBF")]
		[Address(RVA = "0x3183EC0", Offset = "0x3183EC0", VA = "0x3183EC0")]
		public ClothReviewData()
		{
		}
	}

	[Token(Token = "0x4009FA3")]
	[FieldOffset(Offset = "0x8")]
	public List<EventReviewData> event_review;

	[Token(Token = "0x4009FA4")]
	[FieldOffset(Offset = "0xC")]
	public List<CollectionReviewData> collection_review;

	[Token(Token = "0x4009FA5")]
	[FieldOffset(Offset = "0x10")]
	public List<ClothReviewData> cloth_review;

	[Token(Token = "0x6007FBC")]
	[Address(RVA = "0x3183DCC", Offset = "0x3183DCC", VA = "0x3183DCC")]
	public CSGetDigitaluniverseBPlayReviewRes()
	{
	}
}

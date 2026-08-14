using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW;

[Token(Token = "0x200024A")]
public class TrainingShootingGameData : _Attribute
{
	[Token(Token = "0x200024B")]
	public class Level
	{
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0xC")]
		public int hp;

		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x14")]
		public uint count;

		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x18")]
		public uint vest;

		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x1C")]
		public string name;

		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x20")]
		public float interval;

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x232DB84", Offset = "0x232DB84", VA = "0x232DB84")]
		public Level(JSONNode jsonNode)
		{
		}
	}

	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x8")]
	public Level level_L;

	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0xC")]
	public Level level_M;

	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x10")]
	public Level level_H;

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x232D360", Offset = "0x232D360", VA = "0x232D360")]
	public TrainingShootingGameData()
	{
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x232D368", Offset = "0x232D368", VA = "0x232D368", Slot = "4")]
	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}

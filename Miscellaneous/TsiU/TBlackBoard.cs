using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C32")]
public class TBlackBoard
{
	[Token(Token = "0x2003C33")]
	public class TBlackboardItem
	{
		[Token(Token = "0x4019A19")]
		[FieldOffset(Offset = "0x8")]
		private object _value;

		[Token(Token = "0x4019A1A")]
		[FieldOffset(Offset = "0xC")]
		private float _life;

		[Token(Token = "0x601805A")]
		[Address(RVA = "0x2641A2C", Offset = "0x2641A2C", VA = "0x2641A2C")]
		public TBlackboardItem()
		{
		}

		[Token(Token = "0x601805B")]
		[Address(RVA = "0x2641A44", Offset = "0x2641A44", VA = "0x2641A44")]
		public void SetValue(object v)
		{
		}

		[Token(Token = "0x601805C")]
		public T GetValue<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x601805D")]
		[Address(RVA = "0x2641B0C", Offset = "0x2641B0C", VA = "0x2641B0C")]
		public float GetLife()
		{
			return default(float);
		}

		[Token(Token = "0x601805E")]
		[Address(RVA = "0x2641A34", Offset = "0x2641A34", VA = "0x2641A34")]
		public void SetInfinity()
		{
		}

		[Token(Token = "0x601805F")]
		[Address(RVA = "0x2641B14", Offset = "0x2641B14", VA = "0x2641B14")]
		public void SetExpiredTime(float gameTime)
		{
		}

		[Token(Token = "0x6018060")]
		[Address(RVA = "0x2641B2C", Offset = "0x2641B2C", VA = "0x2641B2C")]
		public bool IsExpired(float gameTime)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4019A17")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, TBlackboardItem> _items;

	[Token(Token = "0x4019A18")]
	[FieldOffset(Offset = "0xC")]
	private float _curGameTime;

	[Token(Token = "0x6018055")]
	[Address(RVA = "0x264185C", Offset = "0x264185C", VA = "0x264185C")]
	public TBlackBoard()
	{
	}

	[Token(Token = "0x6018056")]
	[Address(RVA = "0x26418E8", Offset = "0x26418E8", VA = "0x26418E8")]
	public void Update(float gameTime)
	{
	}

	[Token(Token = "0x6018057")]
	[Address(RVA = "0x26418F0", Offset = "0x26418F0", VA = "0x26418F0")]
	public TBlackboardItem SetValue(string key, object v)
	{
		return null;
	}

	[Token(Token = "0x6018058")]
	public T GetValue<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6018059")]
	[Address(RVA = "0x2641A4C", Offset = "0x2641A4C", VA = "0x2641A4C")]
	public float GetLifeTime(string key)
	{
		return default(float);
	}
}

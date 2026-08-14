using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F00")]
public class LocGlobalComponent
{
	[Token(Token = "0x2003F01")]
	public class Language
	{
		[Token(Token = "0x401A971")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x401A972")]
		[FieldOffset(Offset = "0xC")]
		public string FontNormal;

		[Token(Token = "0x401A973")]
		[FieldOffset(Offset = "0x10")]
		public string FontBold;

		[Token(Token = "0x401A974")]
		[FieldOffset(Offset = "0x14")]
		private Font fontNormalRes;

		[Token(Token = "0x401A975")]
		[FieldOffset(Offset = "0x18")]
		private Font fontBoldRes;

		[Token(Token = "0x17001C14")]
		public Font FontNormalRes
		{
			[Token(Token = "0x6019A7D")]
			[Address(RVA = "0x32BE010", Offset = "0x32BE010", VA = "0x32BE010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C15")]
		public Font FontBoldRes
		{
			[Token(Token = "0x6019A7E")]
			[Address(RVA = "0x32BE32C", Offset = "0x32BE32C", VA = "0x32BE32C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6019A7C")]
		[Address(RVA = "0x32BE008", Offset = "0x32BE008", VA = "0x32BE008")]
		public Language()
		{
		}

		[Token(Token = "0x6019A7F")]
		[Address(RVA = "0x32BE0B4", Offset = "0x32BE0B4", VA = "0x32BE0B4")]
		private Font LoadFontRes(string fontpath)
		{
			return null;
		}
	}

	[Token(Token = "0x401A970")]
	[FieldOffset(Offset = "0x8")]
	public List<Language> Languages;

	[Token(Token = "0x6019A7B")]
	[Address(RVA = "0x32BE000", Offset = "0x32BE000", VA = "0x32BE000")]
	public LocGlobalComponent()
	{
	}
}

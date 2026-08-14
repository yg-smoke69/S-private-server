using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C89")]
public class UmaRecipeSimpleLibrary
{
	[Token(Token = "0x4019B9B")]
	public const byte Version = 2;

	[Token(Token = "0x4019B9C")]
	public const byte FlagHasAdditive = 128;

	[Token(Token = "0x4019B9D")]
	public const byte FlagHasHides = 64;

	[Token(Token = "0x4019B9E")]
	public const byte FlagHasSups = 32;

	[Token(Token = "0x4019B9F")]
	public const byte FlagHasBeSups = 16;

	[Token(Token = "0x4019BA0")]
	public const byte FlagHasSupOrBeSups = 48;

	[Token(Token = "0x4019BA1")]
	public const byte FlagMaskSlotCount = 15;

	[Token(Token = "0x4019BA2")]
	public const int EndMark = 2;

	[Token(Token = "0x4019BA3")]
	public const bool ExportBaseRecipes = false;

	[Token(Token = "0x4019BA4")]
	[FieldOffset(Offset = "0x0")]
	public static UmaRecipeSimpleLibrary Instance;

	[Token(Token = "0x4019BA5")]
	[FieldOffset(Offset = "0x8")]
	private bool m_Inited;

	[Token(Token = "0x4019BA6")]
	[FieldOffset(Offset = "0xC")]
	internal int[] m_Data;

	[Token(Token = "0x4019BA7")]
	[FieldOffset(Offset = "0x10")]
	private byte m_Version;

	[Token(Token = "0x4019BA8")]
	[FieldOffset(Offset = "0x12")]
	private ushort m_Count;

	[Token(Token = "0x4019BA9")]
	[FieldOffset(Offset = "0x14")]
	private int[] m_pBaseRecipes;

	[Token(Token = "0x4019BAA")]
	[FieldOffset(Offset = "0x18")]
	private int m_pWardrobeRecipeStart;

	[Token(Token = "0x4019BAB")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, int> m_pWardrobeRecipes;

	[Token(Token = "0x170019A7")]
	public int Count
	{
		[Token(Token = "0x6018387")]
		[Address(RVA = "0x2DE613C", Offset = "0x2DE613C", VA = "0x2DE613C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6018386")]
	[Address(RVA = "0x2DE6134", Offset = "0x2DE6134", VA = "0x2DE6134")]
	public UmaRecipeSimpleLibrary()
	{
	}

	[Token(Token = "0x6018388")]
	[Address(RVA = "0x2DE6144", Offset = "0x2DE6144", VA = "0x2DE6144")]
	public Dictionary<int, int> GetAllRecipes()
	{
		return null;
	}

	[Token(Token = "0x6018389")]
	[Address(RVA = "0x2DE614C", Offset = "0x2DE614C", VA = "0x2DE614C")]
	public void Release(bool releaseBytes = false)
	{
	}

	[Token(Token = "0x601838A")]
	[Address(RVA = "0x2DE6170", Offset = "0x2DE6170", VA = "0x2DE6170")]
	public void Reset()
	{
	}

	[Token(Token = "0x601838B")]
	[Address(RVA = "0x2DE618C", Offset = "0x2DE618C", VA = "0x2DE618C")]
	public static void InitInstanceInNeed()
	{
	}

	[Token(Token = "0x601838C")]
	[Address(RVA = "0x2DE6254", Offset = "0x2DE6254", VA = "0x2DE6254")]
	private void InitInNeed()
	{
	}

	[Token(Token = "0x601838D")]
	[Address(RVA = "0x2DE6430", Offset = "0x2DE6430", VA = "0x2DE6430")]
	public void Load(TextAsset asset)
	{
	}

	[Token(Token = "0x601838E")]
	[Address(RVA = "0x2DE6EB8", Offset = "0x2DE6EB8", VA = "0x2DE6EB8")]
	private bool ReadRecipe(int[] data, ref int p, bool isBase)
	{
		return default(bool);
	}

	[Token(Token = "0x601838F")]
	[Address(RVA = "0x2DE742C", Offset = "0x2DE742C", VA = "0x2DE742C")]
	private bool GetWardrobeReipcePtr(string name, out int ptr)
	{
		return default(bool);
	}

	[Token(Token = "0x6018390")]
	[Address(RVA = "0x2DE745C", Offset = "0x2DE745C", VA = "0x2DE745C")]
	private bool GetWardrobeReipcePtr(int hash, out int ptr)
	{
		return default(bool);
	}

	[Token(Token = "0x6018391")]
	[Address(RVA = "0x2DE74E8", Offset = "0x2DE74E8", VA = "0x2DE74E8")]
	public UmaRecipeSimple GetWardrobeRecipe(string name)
	{
		return default(UmaRecipeSimple);
	}

	[Token(Token = "0x6018392")]
	[Address(RVA = "0x2DE75B4", Offset = "0x2DE75B4", VA = "0x2DE75B4")]
	public UmaRecipeSimple GetWardrobeRecipe(int hash)
	{
		return default(UmaRecipeSimple);
	}

	[Token(Token = "0x6018393")]
	[Address(RVA = "0x2DE7674", Offset = "0x2DE7674", VA = "0x2DE7674")]
	public bool IsWardrobeRecipe(UmaRecipeSimple r)
	{
		return default(bool);
	}
}

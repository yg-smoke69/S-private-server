using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMACharacterSystem;

[Serializable]
[Token(Token = "0x2003CA4")]
public class WardrobeCollectionList
{
	[Token(Token = "0x4019C4D")]
	[FieldOffset(Offset = "0x8")]
	public List<WardrobeSet> sets;

	[Token(Token = "0x170019AA")]
	public List<WardrobeSettings> Item
	{
		[Token(Token = "0x601840E")]
		[Address(RVA = "0x2A587CC", Offset = "0x2A587CC", VA = "0x2A587CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x601840F")]
		[Address(RVA = "0x2A58974", Offset = "0x2A58974", VA = "0x2A58974")]
		set
		{
		}
	}

	[Token(Token = "0x601840D")]
	[Address(RVA = "0x2A58740", Offset = "0x2A58740", VA = "0x2A58740")]
	public WardrobeCollectionList()
	{
	}

	[Token(Token = "0x6018410")]
	[Address(RVA = "0x2A58AF4", Offset = "0x2A58AF4", VA = "0x2A58AF4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6018411")]
	[Address(RVA = "0x2A58B74", Offset = "0x2A58B74", VA = "0x2A58B74")]
	public bool Contains(string race)
	{
		return default(bool);
	}

	[Token(Token = "0x6018412")]
	[Address(RVA = "0x2A58CA0", Offset = "0x2A58CA0", VA = "0x2A58CA0")]
	public void Add(string race)
	{
	}

	[Token(Token = "0x6018413")]
	[Address(RVA = "0x2A58E48", Offset = "0x2A58E48", VA = "0x2A58E48")]
	public void Add(string race, List<WardrobeSettings> settings)
	{
	}

	[Token(Token = "0x6018414")]
	[Address(RVA = "0x2A58FE8", Offset = "0x2A58FE8", VA = "0x2A58FE8")]
	public void Remove(string race)
	{
	}

	[Token(Token = "0x6018415")]
	[Address(RVA = "0x2A5929C", Offset = "0x2A5929C", VA = "0x2A5929C")]
	public List<string> GetAllRacesInCollection()
	{
		return null;
	}

	[Token(Token = "0x6018416")]
	[Address(RVA = "0x2A593D8", Offset = "0x2A593D8", VA = "0x2A593D8")]
	public List<string> GetAllRecipeNamesInCollection(string forRace = "")
	{
		return null;
	}

	[Token(Token = "0x6018417")]
	[Address(RVA = "0x2A587D0", Offset = "0x2A587D0", VA = "0x2A587D0")]
	protected List<WardrobeSettings> GetValue(string key)
	{
		return null;
	}

	[Token(Token = "0x6018418")]
	[Address(RVA = "0x2A58978", Offset = "0x2A58978", VA = "0x2A58978")]
	protected void SetValue(string key, List<WardrobeSettings> value)
	{
	}
}

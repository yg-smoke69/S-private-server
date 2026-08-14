using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMACharacterSystem;

[Token(Token = "0x2003CA5")]
public class DynamicCharacterSystemBase : MonoBehaviour
{
	[Token(Token = "0x6018419")]
	[Address(RVA = "0x2A585A0", Offset = "0x2A585A0", VA = "0x2A585A0")]
	public DynamicCharacterSystemBase()
	{
	}

	[Token(Token = "0x601841A")]
	[Address(RVA = "0x2A585A8", Offset = "0x2A585A8", VA = "0x2A585A8", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x601841B")]
	[Address(RVA = "0x2A585AC", Offset = "0x2A585AC", VA = "0x2A585AC", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x601841C")]
	[Address(RVA = "0x2A585B0", Offset = "0x2A585B0", VA = "0x2A585B0", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x601841D")]
	[Address(RVA = "0x2A585B4", Offset = "0x2A585B4", VA = "0x2A585B4", Slot = "7")]
	public virtual void Refresh(bool forceUpdateRaceLibrary = true, string bundleToGather = "")
	{
	}

	[Token(Token = "0x601841E")]
	[Address(RVA = "0x2A585B8", Offset = "0x2A585B8", VA = "0x2A585B8", Slot = "8")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x601841F")]
	[Address(RVA = "0x2A585BC", Offset = "0x2A585BC", VA = "0x2A585BC", Slot = "9")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6018420")]
	[Address(RVA = "0x2A585C0", Offset = "0x2A585C0", VA = "0x2A585C0", Slot = "10")]
	public virtual UMARecipeBase GetBaseRecipe(string filename, bool dynamicallyAdd = true)
	{
		return null;
	}

	[Token(Token = "0x6018421")]
	[Address(RVA = "0x2A585C8", Offset = "0x2A585C8", VA = "0x2A585C8", Slot = "11")]
	public virtual List<string> GetRecipeNamesForRaceSlot(string race, string slot)
	{
		return null;
	}

	[Token(Token = "0x6018422")]
	[Address(RVA = "0x2A585D0", Offset = "0x2A585D0", VA = "0x2A585D0", Slot = "12")]
	public virtual List<UMARecipeBase> GetRecipesForRaceSlot(string race, string slot)
	{
		return null;
	}

	[Token(Token = "0x6018423")]
	[Address(RVA = "0x2A585D8", Offset = "0x2A585D8", VA = "0x2A585D8", Slot = "13")]
	public virtual bool CheckRecipeAvailability(string recipeName)
	{
		return default(bool);
	}
}

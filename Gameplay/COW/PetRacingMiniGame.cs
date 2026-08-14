using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200085F")]
internal class PetRacingMiniGame
{
	[Token(Token = "0x4005260")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<uint, PetRacerConfigData> m_RacerConfig;

	[Token(Token = "0x4005261")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, PetRacer> m_PetRacers;

	[Token(Token = "0x4005262")]
	[FieldOffset(Offset = "0x10")]
	private uint m_CurPhase;

	[Token(Token = "0x1700040F")]
	public uint CurPhase
	{
		[Token(Token = "0x6003AB2")]
		[Address(RVA = "0x1BFE5DC", Offset = "0x1BFE5DC", VA = "0x1BFE5DC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6003AB1")]
	[Address(RVA = "0x1BFE388", Offset = "0x1BFE388", VA = "0x1BFE388")]
	public PetRacingMiniGame()
	{
	}

	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x1BFE634", Offset = "0x1BFE634", VA = "0x1BFE634")]
	public void OnPetRacingPhaseChange(uint newPhase, uint phaseEndTime)
	{
	}

	[Token(Token = "0x6003AB4")]
	[Address(RVA = "0x1BFE9FC", Offset = "0x1BFE9FC", VA = "0x1BFE9FC")]
	public void SyncPetStates(NLGLPBKNNHJ msg)
	{
	}

	[Token(Token = "0x6003AB5")]
	[Address(RVA = "0x1BFEF48", Offset = "0x1BFEF48", VA = "0x1BFEF48")]
	public PetRacer CreateAndInitSkin(PetRacerConfigData configData)
	{
		return null;
	}

	[Token(Token = "0x6003AB6")]
	[Address(RVA = "0x1BFF2B8", Offset = "0x1BFF2B8", VA = "0x1BFF2B8")]
	public void VoteForPet(IHAAMHPPLMG voter, int voteIndex)
	{
	}

	[Token(Token = "0x6003AB7")]
	[Address(RVA = "0x1BFF4E4", Offset = "0x1BFF4E4", VA = "0x1BFF4E4")]
	public void OnVoteResultReceived(NNJAIPEDEIL msg)
	{
	}

	[Token(Token = "0x6003AB8")]
	[Address(RVA = "0x1BFFC80", Offset = "0x1BFFC80", VA = "0x1BFFC80")]
	public bool CanVote(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003AB9")]
	[Address(RVA = "0x1BFFE58", Offset = "0x1BFFE58", VA = "0x1BFFE58")]
	public PetRacerConfigData GetRacerConfig(uint petID)
	{
		return null;
	}
}

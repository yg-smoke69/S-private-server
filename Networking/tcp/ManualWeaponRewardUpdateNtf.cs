using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D17")]
public class ManualWeaponRewardUpdateNtf
{
	[Token(Token = "0x400B7A5")]
	[FieldOffset(Offset = "0x8")]
	private List<ManualWeaponRewardUpdateInfo> _003Cweapons_003Ek__BackingField;

	[Token(Token = "0x17000BD8")]
	public List<ManualWeaponRewardUpdateInfo> weapons
	{
		[Token(Token = "0x6008716")]
		[Address(RVA = "0x33EC654", Offset = "0x33EC654", VA = "0x33EC654")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008717")]
		[Address(RVA = "0x33EC64C", Offset = "0x33EC64C", VA = "0x33EC64C")]
		private set
		{
		}
	}

	[Token(Token = "0x6008715")]
	[Address(RVA = "0x33EC5C0", Offset = "0x33EC5C0", VA = "0x33EC5C0")]
	public ManualWeaponRewardUpdateNtf()
	{
	}
}

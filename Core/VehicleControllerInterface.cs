using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D0A")]
public interface VehicleControllerInterface
{
	[Token(Token = "0x170019D1")]
	bool ModelVisible
	{
		[Token(Token = "0x6018708")]
		get;
		[Token(Token = "0x6018707")]
		set;
	}

	[Token(Token = "0x170019D2")]
	bool ReachSpeedAndTurnMax
	{
		[Token(Token = "0x6018709")]
		get;
	}

	[Token(Token = "0x170019D3")]
	float SteerAngle
	{
		[Token(Token = "0x601870A")]
		get;
	}

	[Token(Token = "0x170019D4")]
	float Velocity
	{
		[Token(Token = "0x601870B")]
		get;
	}

	[Token(Token = "0x170019D5")]
	float GasInput
	{
		[Token(Token = "0x601870C")]
		get;
	}

	[Token(Token = "0x170019D6")]
	float BrakeInput
	{
		[Token(Token = "0x601870D")]
		get;
	}

	[Token(Token = "0x170019D7")]
	float SteerInput
	{
		[Token(Token = "0x601870E")]
		get;
	}

	[Token(Token = "0x170019D8")]
	int Direction
	{
		[Token(Token = "0x601870F")]
		get;
	}

	[Token(Token = "0x170019D9")]
	bool IsGrounded
	{
		[Token(Token = "0x6018710")]
		get;
	}

	[Token(Token = "0x170019DA")]
	float CurEngineRPM
	{
		[Token(Token = "0x6018711")]
		get;
	}

	[Token(Token = "0x170019DB")]
	bool IsInWater
	{
		[Token(Token = "0x6018713")]
		get;
		[Token(Token = "0x6018714")]
		set;
	}

	[Token(Token = "0x170019DC")]
	Transform VehicleCOM
	{
		[Token(Token = "0x6018715")]
		get;
	}

	[Token(Token = "0x170019DD")]
	VehicleControllerInfo ControllerInfo
	{
		[Token(Token = "0x6018716")]
		get;
	}

	[Token(Token = "0x6018712")]
	float CaculateVehicleRevs();

	[Token(Token = "0x6018717")]
	void BindVehicleSkin(VehicleSkinInfoBase skin_info);

	[Token(Token = "0x6018718")]
	void SetControllerInfo(VehicleControllerInfo i);

	[Token(Token = "0x6018719")]
	void SetVehicleEnable(bool isEnable, bool switchController = false);

	[Token(Token = "0x601871A")]
	void SetMaxSpeedScale(float scale);

	[Token(Token = "0x601871B")]
	void SetDriverSpeedScale(float scale);

	[Token(Token = "0x601871C")]
	float GetDriverSpeedScale();

	[Token(Token = "0x601871D")]
	void LockMaxSpeed(float speed);

	[Token(Token = "0x601871E")]
	void UnLockMaxSpeed();

	[Token(Token = "0x601871F")]
	void UpdateVehicleSpeed(float rpm, float velocity);

	[Token(Token = "0x6018720")]
	void UpdateVehicleSteerAngle(float steerAngle);

	[Token(Token = "0x6018721")]
	void VehicleLazyFixedUpdate(float gameTime, float deltaTime);

	[Token(Token = "0x6018722")]
	void VehicleLasyUpdate(float gameTime, float deltaTime);

	[Token(Token = "0x6018723")]
	void VehicleUpdateInput(bool gas, bool brake, Vector3 steer);

	[Token(Token = "0x6018724")]
	void VehicleUpdateInput(float gas, float brake, Vector3 steer);

	[Token(Token = "0x6018725")]
	void KillEngine();

	[Token(Token = "0x6018726")]
	void StartEngine();

	[Token(Token = "0x6018727")]
	int GetWheelType(GameObject go);

	[Token(Token = "0x6018728")]
	void StartBoost(float torque, float maxSpeed, float angle);

	[Token(Token = "0x6018729")]
	void StopBoost();

	[Token(Token = "0x601872A")]
	void SetJumpHeightRate(float rate);

	[Token(Token = "0x601872B")]
	void SetHightSpeedSteerAngleRate(float rate);

	[Token(Token = "0x601872C")]
	void SetEngineTorqueRate(float rate);

	[Token(Token = "0x601872D")]
	void SetBrakeTorqueRate(float rate);

	[Token(Token = "0x601872E")]
	void ForceStop();
}

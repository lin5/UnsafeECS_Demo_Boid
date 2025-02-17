
//------------------------------------------------------------------------------    
// <auto-generated>                                                                 
//     This code was generated by Tools.MacroExpansion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null. 
//     https://github.com/JiepengTan/LockstepEngine                                          
//     Changes to this file may cause incorrect behavior and will be lost if        
//     the code is regenerated.                                                     
// </auto-generated>                                                                
//------------------------------------------------------------------------------  

//Power by ME //src: https://github.com/JiepengTan/ME  

//#define DONT_USE_GENERATE_CODE                                                                 
                                                                                                 
using System.Linq;                                                                               
using Lockstep.Serialization;                                                                    
using System.Runtime.InteropServices;                                                            
using System.Runtime.CompilerServices;                                                            
using System;                                                                                    
using Lockstep.InternalUnsafeECS;                                                               
using System.Collections;                                                                        
using Lockstep.Math;                                                                             
using System.Collections.Generic;                                                                
using Lockstep.Logging;                                                                          
using Lockstep.Util;                                                                          
namespace Lockstep.UnsafeECS.Game {                                                              
#if !DONT_USE_GENERATE_CODE                                                                      
    public unsafe partial class Context {    
        
        private void RegisterSystemFunctions(){
            _RegisterExecuteSystemFunc();
            _RegisterPostScheduleSystemFunc();
        }
        public void _RegisterExecuteSystemFunc(){
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.MoveSystem),ScheduleMoveSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.MoveForwardSystem),ScheduleMoveForwardSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.TimerSystem),ScheduleTimerSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.CreateDestroySystem),ScheduleCreateDestroySystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidSpawnerSystem),ScheduleBoidSpawnerSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidViewTransformUpdateSystem),ScheduleBoidViewTransformUpdateSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidTargetMoveSystem),ScheduleBoidTargetMoveSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidCreateDestroySystem),ScheduleBoidCreateDestroySystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidCopyStateSystem),ScheduleBoidCopyStateSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidHashPosSystem),ScheduleBoidHashPosSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidMergeSystem),ScheduleBoidMergeSystem);
            RegisterScheduleSystemFunc(typeof(Lockstep.UnsafeECS.Game.BoidSteerSystem),ScheduleBoidSteerSystem);
 
        }
        public void _RegisterPostScheduleSystemFunc(){
            RegisterPostScheduleSystemFunc(EntityIds.BoidSpawner,PostUpdateCreateBoidSpawner);
            RegisterPostScheduleSystemFunc(EntityIds.BoidCell,PostUpdateCreateBoidCell);
            RegisterPostScheduleSystemFunc(EntityIds.Boid,PostUpdateCreateBoid);
            RegisterPostScheduleSystemFunc(EntityIds.BoidTarget,PostUpdateCreateBoidTarget);
            RegisterPostScheduleSystemFunc(EntityIds.BoidObstacle,PostUpdateCreateBoidObstacle);
            RegisterPostScheduleSystemFunc(EntityIds.Item,PostUpdateCreateItem);
            RegisterPostScheduleSystemFunc(EntityIds.Camp,PostUpdateCreateCamp);
            RegisterPostScheduleSystemFunc(EntityIds.Player,PostUpdateCreatePlayer);
            RegisterPostScheduleSystemFunc(EntityIds.Enemy,PostUpdateCreateEnemy);
            RegisterPostScheduleSystemFunc(EntityIds.Bullet,PostUpdateCreateBullet);
            RegisterPostScheduleSystemFunc(EntityIds.Spawner,PostUpdateCreateSpawner);
 
        }

    }                                                                                
#endif                                                                                           
}                                                                                               
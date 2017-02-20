﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AppsDBEntities : DbContext
    {
        public AppsDBEntities()
            : base("name=AppsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SysSample> SysSample { get; set; }
        public virtual DbSet<SysModule> SysModule { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysException> SysException { get; set; }
        public virtual DbSet<SysModuleOperate> SysModuleOperate { get; set; }
        public virtual DbSet<SysRight> SysRight { get; set; }
        public virtual DbSet<SysRightOperate> SysRightOperate { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<MIS_Article> MIS_Article { get; set; }
        public virtual DbSet<MIS_Article_Category> MIS_Article_Category { get; set; }
        public virtual DbSet<SysStruct> SysStruct { get; set; }
    
        public virtual ObjectResult<P_Sys_GetRightOperate_Result> P_Sys_GetRightOperate(string userId, string url)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_Sys_GetRightOperate_Result>("P_Sys_GetRightOperate", userIdParameter, urlParameter);
        }
    
        public virtual int P_Sys_InsertSysRight()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_InsertSysRight");
        }
    
        public virtual int P_Sys_ClearUnusedRightOperate()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_ClearUnusedRightOperate");
        }
    
        public virtual ObjectResult<P_Sys_GetRightByRoleAndModule_Result> P_Sys_GetRightByRoleAndModule(string roleId, string moduleId)
        {
            var roleIdParameter = roleId != null ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(string));
    
            var moduleIdParameter = moduleId != null ?
                new ObjectParameter("moduleId", moduleId) :
                new ObjectParameter("moduleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_Sys_GetRightByRoleAndModule_Result>("P_Sys_GetRightByRoleAndModule", roleIdParameter, moduleIdParameter);
        }
    
        public virtual int P_Sys_UpdateSysRightRightFlag(string moduleId, string roleId)
        {
            var moduleIdParameter = moduleId != null ?
                new ObjectParameter("moduleId", moduleId) :
                new ObjectParameter("moduleId", typeof(string));
    
            var roleIdParameter = roleId != null ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_UpdateSysRightRightFlag", moduleIdParameter, roleIdParameter);
        }
    
        public virtual ObjectResult<P_Sys_GetRoleByUserId_Result> P_Sys_GetRoleByUserId(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_Sys_GetRoleByUserId_Result>("P_Sys_GetRoleByUserId", userIdParameter);
        }
    
        public virtual int P_Sys_UpdateSysRoleSysUser(string roleId, string userId)
        {
            var roleIdParameter = roleId != null ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(string));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_UpdateSysRoleSysUser", roleIdParameter, userIdParameter);
        }
    
        public virtual int P_Sys_DeleteSysRoleSysUserByUserId(string userId)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_DeleteSysRoleSysUserByUserId", userIdParameter);
        }
    
        public virtual int P_Sys_DeleteSysRoleSysUserByRoleId(string roleId)
        {
            var roleIdParameter = roleId != null ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_Sys_DeleteSysRoleSysUserByRoleId", roleIdParameter);
        }
    
        public virtual ObjectResult<P_Sys_GetUserByRoleId_Result> P_Sys_GetUserByRoleId(string roleId)
        {
            var roleIdParameter = roleId != null ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_Sys_GetUserByRoleId_Result>("P_Sys_GetUserByRoleId", roleIdParameter);
        }
    }
}

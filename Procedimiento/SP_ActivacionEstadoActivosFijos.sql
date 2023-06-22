
IF OBJECT_ID('SP_ActivacionEstadoActivosFijos') IS NOT NULL
BEGIN
    DROP PROCEDURE SP_ActivacionEstadoActivosFijos
    IF OBJECT_ID('SP_ActivacionEstadoActivosFijos') IS NOT NULL
        PRINT '<<< FAILED DROPPING PROCEDURE SP_ActivacionEstadoActivosFijos >>>'
    ELSE
        PRINT '<<< DROPPED PROCEDURE SP_ActivacionEstadoActivosFijos >>>'
END
GO
CREATE PROCEDURE SP_ActivacionEstadoActivosFijos
	@xml XML,
	@pcga bit,
	@niif bit,
	@Actualizacion char(1)

AS
/*
exec SP_ActivacionEstadoActivosFijos 
JAIRO YESID LANCHEROS
DESCRIPCION: elimina movientos seleccionados
*/
BEGIN

	DECLARE @MensajeError varchar(max) = ''
	
	DECLARE @DATOS TABLE (
		codigo decimal(18,0)
	  )
	
	BEGIN TRANSACTION T1
		BEGIN TRY
			--EJECUCION Y VALIDACION
			INSERT INTO @DATOS
			SELECT Tbl.Col.value('@codigo', 'decimal(18,0)')
			FROM @xml.nodes('//row') Tbl(Col)


			IF @Actualizacion = 'A'
				BEGIN
					
					IF @pcga = 1
						BEGIN
							UPDATE UNOEEALIAR.dbo.t263_af_activos_fijos_adicion
							SET f263_ind_estado = 1
							WHERE f263_rowid_af IN (SELECT f262_rowid
													FROM UNOEEALIAR.dbo.t262_af_activos_fijos
													WHERE f262_id IN (SELECT DISTINCT codigo
																	  FROM @DATOS))
							AND f263_ind_estado = 2						  

						END
					IF @niif = 1
						BEGIN
							UPDATE UNOEEALIAR.dbo.t2631_af_activos_fijos_niif
								SET f2631_ind_estado = 1
								WHERE f2631_rowid_af IN (SELECT f262_rowid
														 FROM UNOEEALIAR.dbo.t262_af_activos_fijos
														 WHERE f262_id IN (SELECT DISTINCT codigo
																	  FROM @DATOS))
								AND f2631_ind_estado = 2											   
						END

				END
			ELSE IF @Actualizacion = 'S'
				BEGIN
					
					IF @pcga = 1
						BEGIN
							UPDATE UNOEEALIAR.dbo.t263_af_activos_fijos_adicion
							SET f263_ind_estado = 2
							WHERE f263_rowid_af IN (SELECT f262_rowid
													FROM UNOEEALIAR.dbo.t262_af_activos_fijos
													WHERE f262_id IN (SELECT DISTINCT codigo
																	  FROM @DATOS))
							AND f263_ind_estado = 1			

						END
					IF @niif = 1
						BEGIN
						UPDATE UNOEEALIAR.dbo.t2631_af_activos_fijos_niif
						SET f2631_ind_estado = 2
						WHERE f2631_rowid_af IN (SELECT f262_rowid
												 FROM UNOEEALIAR.dbo.t262_af_activos_fijos
												 WHERE f262_id IN (SELECT DISTINCT codigo
																	  FROM @DATOS))
						AND f2631_ind_estado = 1											   
						END


				END


			
			select @MensajeError
			COMMIT TRANSACTION T1
		END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION T1
		set @MensajeError = ERROR_MESSAGE()
		select @MensajeError
	END CATCH

END
GO
IF OBJECT_ID('SP_ActivacionEstadoActivosFijos') IS NOT NULL
    PRINT '<<< CREATED PROCEDURE SP_ActivacionEstadoActivosFijos >>>'
ELSE
    PRINT '<<< FAILED CREATING PROCEDURE SP_ActivacionEstadoActivosFijos >>>'

	
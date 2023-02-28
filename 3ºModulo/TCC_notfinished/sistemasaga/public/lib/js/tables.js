/* TRADUÇÃO DATATABLES */
$(document).ready(function() {
	var traducao = {'language' : 

				{
				    "sEmptyTable": "Nenhum registro encontrado",
				    "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
				    "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
				    "sInfoFiltered": "(Filtrados de _MAX_ registros)",
				    "sInfoPostFix": "",
				    "sInfoThousands": ".",
				    "sLengthMenu": "_MENU_ Resultados por página",
				    "sLoadingRecords": "Carregando...",
				    "sProcessing": "Processando...",
				    "sZeroRecords": "Nenhum registro encontrado",
				    "sSearch": "Pesquisar",
				    "oPaginate": {
				        "sNext": "Próxima",
				        "sPrevious": "Anterior",
				        "sFirst": "Primeiro",
				        "sLast": "Último"
				    },
				    "oAria": {
				        "sSortAscending": ": Ordenar colunas de forma ascendente",
				        "sSortDescending": ": Ordenar colunas de forma descendente"
				    }
				}
	}

    $('#users_table').DataTable(traducao);
    $('#cursos_table').DataTable(traducao);
    $('#disciplinas_table').DataTable(traducao);
    $('#turnos_table').DataTable(traducao);
    $('#turmas_table').DataTable(traducao);
    $('#instituicoes_table').DataTable(traducao);
    $('#materiais_table').DataTable(traducao);

} );
/* FIM TRADUÇÃO DATATABLES */

/* BUSCA DE CEP */
	jQuery(function($){
	    $("#cep").change(function(){
	      var cep_code = $(this).val();
	      if( cep_code.length <= 0 ) return;
	      $.get("http://apps.widenet.com.br/busca-cep/api/cep.json", { code: cep_code },
	         function(result){
	            if( result.status!=1 ){
	               alert(result.message || "Houve um erro desconhecido");
	               return;
	            }
	            $("input#cep").val( result.code );
	            $("input#estado").val( result.state );
	            $("input#cidade").val( result.city );
	            $("input#bairro").val( result.district );
	            $("input#endereco").val( result.address );
	            $("input#estado").val( result.state );
	         });
	    });
	});
/* FIM BUSCA DE CEP */

/* MASCARA PROS FORMS */
	function formatar(mascara, documento){
        var i = documento.value.length;
        var saida = mascara.substring(0,1);
        var texto = mascara.substring(i)
                                          
        if (texto.substring(0,1) != saida){
            documento.value += texto.substring(0,1);
        }
                                          
    }
/* FIM MASCARA PROS FORMS */
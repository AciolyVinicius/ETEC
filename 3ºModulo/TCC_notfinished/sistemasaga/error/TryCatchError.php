<?php
class TryCatchError {
	public static function erro(Exception $e){
		ob_clean();
		if (DEBUG) {
		    echo "<pre>";
		    print_r($e);
		    echo "</pre>";
		} else {
        	echo $e->getMessage();
		}
		die();
	}
}